using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Automates
{
    /// <summary>
    /// Class de sauvegarde d'un automate dans un fichier de type "aut"
    /// </summary>
    public class AutomateSaver
    {
        /// <summary>
        /// Le type de resultat apres le sauvegarde
        /// </summary>
        public enum AutomtateSaveResult
        {
            NEW, /// sauvergaredement sans erreurs
            REPLACE,///sauvegardement avec remplacement en cas de l'existance du fichier
            ERROR ///Erreur lors du sauvegarde
        }


        public AutomateSaver()
        {


        }

        /// <summary>
        /// Sauvegarder l'automate dans un ficher 
        /// </summary>
        /// <param name="Automate">l'automate à sauvegarder</param>
        /// <param name="FileName">le nom du fichier</param>
        /// <param name="folder">le repertoire qui va contenir le fichier</param>
        /// <returns>le resultat du sauvegarde</returns>
        public AutomtateSaveResult Save(Automata Automate, String FileName, String folder)
        {
            return Save(Automate, folder + FileName);
        }

        /// <summary>
        ///  Sauvegarder l'automate dans un ficher 
        /// </summary>


        /// <param name="Automate">L'automate à sauvegarder.</param>
        /// <param name="Path">le path du fichier</param>
        /// <returns>Le resultat du sauvegarde</returns>
        public AutomtateSaveResult Save(Automata Automate, String Path)
        {
            AutomtateSaveResult ret = new AutomtateSaveResult();
            //StreamReader sr = null;
            StreamWriter sw = null;

            try
            {
            if (File.Exists(Path))
            {
                File.Delete(Path);
                ret = AutomtateSaveResult.REPLACE;
            }
            // Le fichier n'existe pas. On le crée.
            sw = new StreamWriter(Path);
            sw.WriteLine("<Automate>");

            sw.WriteLine("  <Name>{0}</Name>", Automate.Name);

            sw.WriteLine("  <Type>{0}</Type>", (int)Automate.getType());

            sw.WriteLine("  <X>");
            foreach (char car in Automate.X)
                sw.WriteLine("      <car>{0}</car>", car);
            sw.WriteLine("  </X>");

            sw.WriteLine("  <S0>{0}</S0>", Automate.S0);
            sw.WriteLine("  <S>{0}</S>", Automate.S);

            sw.WriteLine("  <F>");
            foreach (int fi in Automate.F)
                sw.WriteLine("      <fi>{0}</fi>", fi);
            sw.WriteLine("  </F>");

            sw.WriteLine("  <I>");
            for (int i = 0; i < Automate.S; i++)
                if (Automate.getType() == Automata.TYPE.Gfa)
                    foreach (object motObj in ((Gfa)Automate).Read)
                    {
                        string mot = motObj.ToString();
                        foreach (int j in ((Gfa)Automate).getInstruction(i, mot))
                            sw.WriteLine("      <triplet>({0},{1},{2})</triplet>", i, mot, j);
                    }
                else
                {
                    foreach (char car in Automate.X)
                        switch (Automate.getType())
                        {
                            case Automata.TYPE.Dfa:
                                if (((Dfa)Automate).getInstruction(i, car) != -1)
                                    sw.WriteLine("      <triplet>({0},{1},{2})</triplet>", i, car, ((Dfa)Automate).getInstruction(i, car));
                                break;
                            case Automata.TYPE.Nfa:
                                foreach (int j in ((Nfa)Automate).getInstruction(i, car))
                                    sw.WriteLine("      <triplet>({0},{1},{2})</triplet>", i, car, j);
                                break;
                            case Automata.TYPE.PGfa:
                                foreach (int j in ((PGfa)Automate).getInstruction(i, car))
                                    sw.WriteLine("      <triplet>({0},{1},{2})</triplet>", i, car, j);
                                break;
                            case Automata.TYPE.Gfa:
                                //deja fait
                                break;
                            default:
                                break;
                        }
                }

            sw.WriteLine("  </I>");



            sw.WriteLine("</Automate>");
            sw.Close();
            sw = null;

        }
            catch (Exception ex)
            {
                ret = AutomtateSaveResult.ERROR;
                System.Windows.Forms.MessageBox.Show("Erreur lors de sauvegarde : \n"+ex.Message, "Erreur", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
            }
            finally
            {
            
            // Fermeture streamwriter
            if (sw != null) sw.Close();
            if (ret != AutomtateSaveResult.REPLACE) ret = AutomtateSaveResult.NEW;
            }

            return ret;
        }
    }
}
