namespace AirdropClipboarder
{
    public class Settings
    {
        private DataList m_DataList;
        private Launchers m_LauncherDic;

        public Settings()
        {
            m_DataList = new DataList();
            m_LauncherDic = new Launchers();
        }

        public DataList MyDataList
        {
            get
            {
                return m_DataList;
            }

            set
            {
                m_DataList = value;
            }
        }

        internal Launchers LauncherDic
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
    }
}
