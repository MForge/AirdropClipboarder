using System;
using System.Collections.Generic;
using System.Linq;

namespace AirdropClipboarder
{


    class Launchers
    {
        private Dictionary<string, string> m_LauncherDic;

        public Launchers()
        {
            m_LauncherDic = new Dictionary<string, string>();
        }

        public Dictionary<string, string> LauncherDic
        {
            get
            {
                return m_LauncherDic;
            }

            set
            {
                m_LauncherDic = value;
            }
        }

        public void add(string Social, string link)
        {
            try
            {
                if (!m_LauncherDic.ContainsKey(Social))
                {
                    m_LauncherDic.Add(Social, link);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void remove(string Social)
        {
            try
            {
                if (m_LauncherDic.ContainsKey(Social))
                {
                    m_LauncherDic.Remove(Social);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void clear()
        {
            m_LauncherDic.Clear();
        }

        public int count()
        {
            return m_LauncherDic.Count();
        }

        public string getLink(string Social)
        {
            string toreturn = "";
            try
            {
                if (m_LauncherDic.ContainsKey(Social))
                {
                    toreturn = m_LauncherDic[Social];
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return toreturn;
        }
    }
}
