using System;

namespace AirdropClipboarder
{
    public class Data
    {
        private string m_ID;
        private string m_mydata;
        private string m_description;

        public Data()
        {
            m_ID = Guid.NewGuid().ToString();
            m_mydata = "";
            m_description = "";
        }

        public Data(string aID, string aData, string aDescription)
        {
            m_ID = aID;
            m_mydata = aData;
            m_description = aDescription;
        }

        public Data(string aData, string aDescription)
        {
            m_ID = Guid.NewGuid().ToString();
            m_mydata = aData;
            m_description = aDescription;
        }

        public int SortByOrdeAscending(int order1, int order2)
        {
            return order1.CompareTo(order2);
        }

        public string MyData
        {
            get
            {
                return m_mydata;
            }

            set
            {
                m_mydata = value;
            }
        }

        public string Description
        {
            get
            {
                return m_description;
            }

            set
            {
                m_description = value;
            }
        }

        public string ID
        {
            get
            {
                return m_ID;
            }

            set
            {
                m_ID = value;
            }
        }
    }
}
