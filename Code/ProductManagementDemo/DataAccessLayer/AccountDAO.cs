using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            AccountMember accountMember = new AccountMember();

            if (accountID.Equals("Mi"))
            {
                accountMember.MemberId = accountID;
                accountMember.MemberPassword = "mi";
                accountMember.MemberRole = 1;
               
            }
            return accountMember;
        }
    }
}