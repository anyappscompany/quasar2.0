using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace quasar2._0
{
    class RndAccounts
    {
        private ListBox li;
        public RndAccounts(ListBox li)
        {
            this.li = li;
        }
        
        private string StringAccounts()
        {
            string StrAccounts;
            Random rnd = new Random();                
            StrAccounts = li.Items[rnd.Next(li.Items.Count)].ToString();                      
            return (string)StrAccounts;
        }

        public AccountsData GetAccounts()
        {
            AccountsData pd = new AccountsData();
            String StrAccounts;            
            StrAccounts = StringAccounts();
            String[] AccountsF = StrAccounts.Split(new String[] { ":" }, StringSplitOptions.None);            
            pd.Login = AccountsF[0].ToString();
            pd.Password = AccountsF[1].ToString();
            return pd; 
        }
    }
}
