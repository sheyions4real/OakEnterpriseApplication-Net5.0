using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using LeaveManagement.Constants;
using LeaveManagement.Contracts;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Employee> _signInManager;
        private readonly UserManager<Employee> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmployeeProfileRepository employeeProfileRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<Employee> userManager,  // handle access to all the user objects
            SignInManager<Employee> signInManager,  // handles all sign in and token generation operations
            ILogger<RegisterModel> logger,          // logger
            IEmployeeProfileRepository employeeProfileRepository,
            IDepartmentRepository departmentRepository,
            IMapper mapper,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            this.employeeProfileRepository = employeeProfileRepository;
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        //keep history of the current page before registration to determine where to send the user to after registration
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required]
            [Display(Name = "Lastname")]
            public string Lastname { get; set; }

            
            [Display(Name = "Firstname")]
            public string Firstname { get; set; }


            [Display(Name = "Department")]
            public string Department { get; set; }
            public SelectList DeptList { get; set; }



            [Display(Name = "Date Of Birth")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
            public DateTime Date_Of_Birth { get; set; }



            [Display(Name = "Date Employed")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
            public DateTime? Date_Employed { get; set; }

            
            [Display(Name = "Date Confirmed")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
            public DateTime? Date_Confirmed { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            List<SelectListItem> list = new List<SelectListItem>();

            var departments = await departmentRepository.GetAllAsync();
         

            foreach (var item in departments)
            {
                list.Add(new SelectListItem() { Text = item.Name, Value = item.Id });
            }
            //list.Add(new SelectListItem() { Text = "Customer Care", Value = "535f3413-5f18-426f-9f20-944aad334523" });
            //list.Add(new SelectListItem() { Text = "Operations", Value = "135f3413-2f18-426f-9f20-944aa1314623" });
            //list.Add(new SelectListItem() { Text = "ICT", Value = "235f3413-2f18-426f-9f20-944aad3a4623" });

            //list.Add(new SelectListItem() { Text = "Benefit", Value = "335f3413-2f18-426f-9f20-944aad323623" });
            //list.Add(new SelectListItem() { Text = "BDRM", Value = "435f3413-2f18-426f-9f20-544aad364623" });
            //list.Add(new SelectListItem() { Text = "FINCON", Value = "435f3413-2f18-426f-9f20-944aa4344643" });

            //list.Add(new SelectListItem() { Text = "Internal Audit", Value = "535f3413-2f18-456f-9f20-944aad544623" });
            //list.Add(new SelectListItem() { Text = "Investment", Value = "a35f3413-2f18-42af-9f20-94aaad394623" });
            //list.Add(new SelectListItem() { Text = "HR/Admin", Value = "a35f3413-5f18-426f-6f20-944aa6314623" });


            //list.Add(new SelectListItem() { Text = "Legal", Value = "b35f3413-2f18-4b6f-9f20-944bbd334623" });
            //list.Add(new SelectListItem() { Text = "Compliance", Value = "a35f3413-2fa8-426f-9f20-944aad3r4623" });
            //list.Add(new SelectListItem() { Text = "MD Office", Value = "c35f3413-2318-426f-9e20-944aad3r46c3" });

            ViewData["DeptList"] = list;

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");  // to check if the host called this registration
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                //create a new Employee
                var user = new Employee { UserName = Input.Email, Email = Input.Email };
                user.Firstname = Input.Firstname;
                user.Lastname = Input.Lastname;
                user.DateConfirmed = Input.Date_Confirmed ?? default;
                user.DateEmployed = Input.Date_Employed ?? default;
                user.DateOfBirth = Input.Date_Of_Birth;
                user.DepartmentID = Input.Department;



                var result = await _userManager.CreateAsync(user, Input.Password);


                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    // assign role to the user
                    await _userManager.AddToRoleAsync(user, Roles.User);


                    // save user to staff table
                    var staff = mapper.Map<EmployeeProfile>(user);

                    await employeeProfileRepository.AddAsync(staff);


                    // generate token to be sent via email to user email for confirmation
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);


                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
