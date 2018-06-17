using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AirdropClipboarder
{
    public class DataList : IEnumerable
    {
        private List<Data> m_DataList = new List<Data>();

        public void add(Data aDatar)
        {
            try
            {
                m_DataList.Add(aDatar);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void delete(Data aData)
        {
            try
            {
                if (m_DataList.Contains(aData))
                {
                    m_DataList.Remove(aData);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void delete(string aID)
        {
            try
            {
                foreach (Data aData in m_DataList)
                {
                    if (aData.ID == aID)
                    {
                        m_DataList.Remove(aData);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void delete(string aMyData, string aDescription)
        {
            try
            {
                foreach (Data aData in m_DataList)
                {
                    if (aData.MyData == aMyData && aData.Description == aDescription)
                    {
                        m_DataList.Remove(aData);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool getDataByName(string aMyData, out Data aData)
        {
            bool toReturn = false;
            aData = new Data();
            foreach (Data m in m_DataList)
            {
                if (m.MyData == aMyData)
                {
                    toReturn = true;
                    aData = m;
                    break;
                }
            }

            return toReturn;
        }

        public void clear()
        {
            m_DataList.Clear();
        }

        public int count()
        {
            return m_DataList.Count();
        }

        public Data getData(int index)
        {
            return m_DataList[index];
        }

        public bool content(string aMyData, string aDescription)
        {
            bool toReturn = false;
            foreach (Data m in m_DataList)
            {
                if (m.MyData == aMyData && m.Description == aDescription)
                {
                    toReturn = true;
                    break;
                }
            }
            return toReturn;
        }

        #region implémentation IEnumerable

        public MinerEnumerator GetEnumerator() // non-IEnumerable version
        {
            return new MinerEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator() // IEnumerable version
        {
            return (IEnumerator)new MinerEnumerator(this);
        }

        //************************************************************************
        //****************** Classe d'Iteration **********************************
        //************************************************************************

        public class MinerEnumerator : IEnumerator
        {
            private int position = -1;
            private DataList t;

            public MinerEnumerator(DataList t)
            {
                this.t = t;
            }

            public bool MoveNext()
            {
                if (position < t.count() - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            public Data Current // non-IEnumerator version: type-safe
            {
                get
                {
                    return t.getData(position);
                }
            }

            object IEnumerator.Current // IEnumerator version: returns object
            {
                get
                {
                    return t.getData(position);
                }
            }
        }

        //************************************************************************
        //************************************************************************
        //************************************************************************

        #endregion implémentation IEnumerable
    }
}
