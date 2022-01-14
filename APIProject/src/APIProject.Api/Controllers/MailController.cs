using System;
using APIProject.Api.Tests;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Api.Controllers
{
    public class MailController : ControllerBase
    {
        public ActionResult SendVoucherEmail(VoucherEmailRequest request)
        {
            return Ok();
        }
    }
}