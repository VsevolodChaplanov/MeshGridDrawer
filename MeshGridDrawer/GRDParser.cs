using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace MeshGridDrawer
{
    class GRDParser
    {
        // Разделитель
        private string Separator { set; get; }
        // Состояние считывание
        private enum ParserStates { None,
        Header,
        Values};

        public static GRDContainer ParseFile(string fileName, char Separator = ' ')
        {
            GRDContainer valStore = new GRDContainer();
            try
            {
                uint k = 0;
                foreach(string line in File.ReadLines(fileName))
                {
                    try
                    {
                        // Костыль:
                        // В конце массива @values лежит пустой символ
                        string linetoparse = Regex.Replace(line, @"  +", " ");
                        string[] values = linetoparse.Split(Separator);
                        if (k == 0)
                        {
                            k++;
                            continue;
                        }
                        if (k == 1)
                        {
                            valStore.setNx(uint.Parse(values[0]));
                            valStore.setNy(uint.Parse(values[1]));
                            k++;
                            continue;
                        }
                        if (k == 2)
                        {
                            valStore.setxMin(Double.Parse(values[0]));
                            valStore.setxMax(Double.Parse(values[1]));
                            k++;
                            continue;
                        }
                        if (k == 3)
                        {
                            valStore.setyMin(Double.Parse(values[0]));
                            valStore.setyMax(Double.Parse(values[1]));
                            k++;
                            continue;
                        }
                        if (k == 4)
                        {
                            valStore.setzMin(Double.Parse(values[0]));
                            valStore.setzMax(Double.Parse(values[1]));
                            k++;
                            continue;
                        }
                        foreach (string element in values)
                        {
                            valStore.Append(Double.Parse(element)); 
                        }
                        k++;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
            }
                     
            return valStore;
        }
    }
}
