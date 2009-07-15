using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;
using System.Xml.XPath;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Automates
{
    public struct Auto
    {
        public Automata.TYPE type;
        public Object Automate;
        public Auto(Automata automate)
        {
            Automate = automate;
            type = automate.getType();
        }

        public override String ToString()
        {
            return ((Automata)Automate).Name;
        }
    }

    class workspace
    {


        public AutomateSaver.AutomtateSaveResult save(ArrayList Automate_list, String Path)
        {


            Directory.CreateDirectory("tmp");
            String Wfolder = Directory.GetCurrentDirectory() + "\\tmp";
            AutomateSaver Saver = new AutomateSaver();
            using (ZipFile Zip = new ZipFile())
            {
                foreach (Auto Auto in Automate_list)
                {
                    if (((Automata)Auto.Automate).getType() == Automata.TYPE.Gfa)
                    {
                        ((Automata)Auto.Automate).Name = "Automate" + (Automate_list.IndexOf(Auto) % 5).ToString();
                        AutomateSaver.AutomtateSaveResult ret = Saver.Save((Automata)(Auto.Automate), Wfolder + "\\" + Auto.ToString() + ".aut");
                        if (ret == AutomateSaver.AutomtateSaveResult.ERROR)
                        {
                            MessageBox.Show("Erreur saving the worspace");
                            return AutomateSaver.AutomtateSaveResult.ERROR;
                        }
                    }
                }


                foreach (string file in Directory.GetFiles("tmp"))
                {
                    Zip.AddFile(file, ".");

                }
                Zip.Save(Path);
                try
                {
                    Directory.Delete("tmp", true);
                }
                catch (Exception)
                {

                }


            }
            return AutomateSaver.AutomtateSaveResult.NEW;
        }

        public ArrayList read(string Path)
        {
            ArrayList temp = new ArrayList();
            Directory.CreateDirectory("tmp");
            String Wfolder = Directory.GetCurrentDirectory() + "\\tmp";
            try
            {
                using (ZipFile zip = ZipFile.Read(Path))
                {
                    zip.ExtractAll(Wfolder, true);
                }
                AutomateReader reader = new AutomateReader();
                foreach (String file in Directory.GetFiles(Wfolder))
                {
                    temp.Add(reader.read(file));
                }
                try
                {
                    Directory.Delete(Wfolder, true);
                }
                catch (Exception)
                {

                }
            }
            catch (ZipException ex)
            {
                MessageBox.Show("Fichier endomager ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return temp;
        }

    }
}
