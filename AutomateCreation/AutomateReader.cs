using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Windows.Forms;
namespace Automates
{
    class AutomateReader
    {

        public Auto read(String Path)
        {
            Auto Auto = new Auto();

            try
            {


                XPathDocument doc = new XPathDocument(Path);


                XPathNavigator nav_Auto = doc.CreateNavigator();
                XPathNodeIterator iter_Auto = nav_Auto.Select("Automate");

                iter_Auto.MoveNext(); // puisque il existe un seul automate node
                {
                    string type = iter_Auto.Current.SelectSingleNode("Type").Value;

                    Auto.type = (Automata.TYPE)int.Parse(iter_Auto.Current.SelectSingleNode("Type").Value);
                    
                    
                    switch (Auto.type)
                    {
                        case Automata.TYPE.Dfa:
                            Auto.Automate = new Dfa();
                            break;
                        case Automata.TYPE.Nfa:
                            Auto.Automate = new Nfa();
                            break;
                        case Automata.TYPE.PGfa:
                            Auto.Automate = new PGfa();
                            break;
                        case Automata.TYPE.Gfa:
                            Auto.Automate = new Gfa();
                            break;
                        default:
                            break;
                    }


                    ((Automata)Auto.Automate).Name = iter_Auto.Current.SelectSingleNode("Name").Value;


                    XPathNodeIterator iter_X = iter_Auto.Current.Select("X/car");
                    ((Automata)Auto.Automate).X = new ArrayList();
                    while (iter_X.MoveNext())
                    {
                        ((Automata)Auto.Automate).X.Add(Char.Parse(iter_X.Current.Value));
                        if (((Automata)Auto.Automate).getType() == Automata.TYPE.Gfa)
                            ((Gfa)Auto.Automate).Read.Add(Char.Parse(iter_X.Current.Value));
                    }

                    ((Automata)Auto.Automate).S0 = int.Parse(iter_Auto.Current.SelectSingleNode("S0").Value);
                    ((Automata)Auto.Automate).S = int.Parse(iter_Auto.Current.SelectSingleNode("S").Value);

                    XPathNodeIterator iter_F = iter_Auto.Current.Select("F/fi");
                    ((Automata)Auto.Automate).F = new ArrayList();
                    while (iter_F.MoveNext())
                    {
                        ((Automata)Auto.Automate).F.Add(int.Parse(iter_F.Current.Value));
                    }


                    if (Auto.type == Automata.TYPE.Dfa)
                    {
                        ((Dfa)Auto.Automate).InitI();
                        XPathNodeIterator iter_I = iter_Auto.Current.Select("I/triplet");
                        ArrayList triplets = new ArrayList();
                        while (iter_I.MoveNext())
                        {
                            triplets.Add(iter_I.Current.Value);

                        }

                        for (int i = 0; i < ((Dfa)Auto.Automate).S; i++)
                            foreach (char car in ((Dfa)Auto.Automate).X)
                                for (int j = 0; j < ((Dfa)Auto.Automate).S; j++)
                                    if (triplets.Contains("(" + i + "," + car + "," + j + ")"))
                                        ((Dfa)Auto.Automate).AddInstruction(i, car, j, true);

                    }
                    else
                    {
                        ((Automata)Auto.Automate).InitI();
                        XPathNodeIterator iter_I = iter_Auto.Current.Select("I/triplet");
                        ArrayList triplets = new ArrayList();
                        while (iter_I.MoveNext())
                        {
                            triplets.Add(iter_I.Current.Value);

                        }

                        for (int i = 0; i < ((Automata)Auto.Automate).S; i++)
                            foreach (char car in ((Automata)Auto.Automate).X)
                                for (int j = 0; j < ((Automata)Auto.Automate).S; j++)
                                {
                                    if (triplets.Contains("(" + i + "," + car + "," + j + ")"))
                                        switch (Auto.type)
                                        {
                                            case Automata.TYPE.Nfa:
                                                ((Nfa)Auto.Automate).AddInstruction(i, car, j);
                                                break;
                                            case Automata.TYPE.PGfa:
                                                ((PGfa)Auto.Automate).AddInstruction(i, car, j);
                                                break;
                                            case Automata.TYPE.Gfa:
                                                ((Gfa)Auto.Automate).AddInstruction(i, car, j);
                                                break;
                                            default:
                                                break;

                                        }

                                }
                    }
                }
            }
            catch (Exception ex)
            {
                Auto.Automate = null;
                MessageBox.Show(ex.Message + "\n" + ex.Source + "\n dans la methode : "+ex.TargetSite+ "\n Verifier si le fichier n'est pas endommagé ", "Erreur lors de l'ecture de l'automate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Auto;
        }
    }
}
