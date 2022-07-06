﻿
namespace Wettkampf.Models
{
    public class Account : ContentItem
    {
        public string AccountName { get; set; }
        public string Password { get; set; }

        public bool CorrectInformation()
        {
            if (string.IsNullOrEmpty(AccountName) || string.IsNullOrEmpty(Password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
    

