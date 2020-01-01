using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace quasar2._0
{
    class RndProxy
    {
        private ListBox li;
        public RndProxy(ListBox li)
        {
            this.li = li;
        }
        
        private string StringProxy()
        {
            string StrProxy;
            Random rnd = new Random();                
            StrProxy = li.Items[rnd.Next(li.Items.Count)].ToString();                      
            return (string)StrProxy;
        }

        public ProxyData GetProxy()
        {
            ProxyData pd = new ProxyData();
            String StrProxy;            
            StrProxy = StringProxy();
            String[] ProxyF = StrProxy.Split(new String[] { ":" }, StringSplitOptions.None);            
            pd.IP = ProxyF[0].ToString();
            pd.Port = Convert.ToInt32(ProxyF[1]);
            return pd; 
        }
    }
}
