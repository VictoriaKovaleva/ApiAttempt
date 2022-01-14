using System;
using System.Net;
using APIProject.Api.Controllers;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Expressions;

namespace APIProject.Api.Tests
{
    public class MailControllerShould
    {
        [Fact]
        public void ReturnASuccessfulResponse()
        {
            MailController controller = new();
            VoucherEmailRequest request = new()
            {
                ClientName = "Exeal Hoteles",
                VoucherLink = "https://registration.voxelgroup.net/",
                RecipientEmail = "vkovaleva@voxelgroup.net"
            };
            
            ActionResult response = controller.SendVoucherEmail(request);
            
            response.Should().BeOfType<OkResult>();
        }
    }
}