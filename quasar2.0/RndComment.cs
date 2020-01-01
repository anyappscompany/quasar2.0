using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace quasar2._0
{
    class RndComment
    {
        private ListBox li;
        public RndComment(ListBox li)
        {
            this.li = li;
        }
        
        public string GetComment()
        {
            string StrComment;
            Random rnd = new Random();                
            StrComment = li.Items[rnd.Next(li.Items.Count)].ToString();                      
            return (string)StrComment;
        } 
    }
}
