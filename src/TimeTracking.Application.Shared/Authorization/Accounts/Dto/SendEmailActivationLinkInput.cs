﻿using System.ComponentModel.DataAnnotations;

namespace TimeTracking.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}