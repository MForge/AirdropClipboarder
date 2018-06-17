using System;
using System.IO;
using System.Xml.Linq;

namespace AirdropClipboarder
{
    class SettingsMgr
    {
        private Settings m_Settings;
        public const string fileName = @"Settings.xml";

        public SettingsMgr()
        {
            m_Settings = new Settings();

        }

        public DataList MyDataList
        {
            get
            {
                return m_Settings.MyDataList;
            }

            set
            {
                m_Settings.MyDataList = value;
            }
        }

        public Launchers MyLaunchers
        {
            get
            {
                return m_Settings.LauncherDic;
            }

            set
            {
                m_Settings.LauncherDic = value;
            }
        }

        public Settings MySettings
        {
            get
            {
                return m_Settings;
            }

            set
            {
                m_Settings = value;
            }
        }

        public void loadFromXml()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    XElement root = XElement.Load(fileName);

                    foreach (XElement el in root.Descendants("Datas").Nodes())
                    {
                        MyDataList.add(new Data(el.Element("ID").Value, el.Element("Data").Value, el.Element("Description").Value));
                    }

                    foreach (XElement el in root.Descendants("Launchers").Nodes())
                    {
                        MyLaunchers.add(el.Element("Social").Value, el.Element("Link").Value);
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void saveToXml()
        {
            try
            {
                XElement rootNode = new XElement("Root");

                // Datas :
                XElement configNode = new XElement("Datas");
                foreach (Data data in MyDataList)
                {
                    XElement DataNode = new XElement("Data");

                    XElement MinerDateNode = new XElement("ID", data.ID);
                    DataNode.Add(MinerDateNode);

                    MinerDateNode = new XElement("Data", data.MyData);
                    DataNode.Add(MinerDateNode);

                    MinerDateNode = new XElement("Description", data.Description);
                    DataNode.Add(MinerDateNode);

                    configNode.Add(DataNode);
                }
                rootNode.Add(configNode);

                // Launchers :
                configNode = new XElement("Launchers");
                foreach (var item in MyLaunchers.LauncherDic)
                {
                    XElement DataNode = new XElement("Launcher");

                    XElement MinerDateNode = new XElement("Social", item.Key);
                    DataNode.Add(MinerDateNode);

                    MinerDateNode = new XElement("Link", item.Value);
                    DataNode.Add(MinerDateNode);

                    configNode.Add(DataNode);
                }
                rootNode.Add(configNode);


                // Save to file :
                rootNode.Save(fileName);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
