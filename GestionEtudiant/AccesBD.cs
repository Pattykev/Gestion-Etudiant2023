using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace GestionEtudiant
{
    class AccesBD
  
    {
        private static OdbcConnection conn = null;
        public static OdbcConnection getConnexion()
        {
            if (conn == null)
            {
                conn = new OdbcConnection("dsn=bdetudiant");
                conn.Open();

            }
            return conn;
        }
        public static string AjouterEtudiant(string nom, string prenom, string dateN, string filiere)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand("insert into etudiant(nom, prenom, datenais, filiere) values(?,?,?,?)", getConnexion());
                cmd.Parameters.AddWithValue("a", nom);
                cmd.Parameters.AddWithValue("b", prenom);
                cmd.Parameters.AddWithValue("c", dateN);
                cmd.Parameters.AddWithValue("d", filiere);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "etudiant inséré avec succès";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string AjouterNote(string nom, string prenom, string filiere, string libelle, string date, double note)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand("insert into evaluation(id_etudiant, id_matiere, datecompos, note) values((select id_etudiant from etudiant where nom=? and prenom=? and filiere=?),(select id_matiere from matiere where libelle=?),?,?)", getConnexion());
                cmd.Parameters.AddWithValue("a", nom);
                cmd.Parameters.AddWithValue("b", prenom);
                cmd.Parameters.AddWithValue("c", filiere);
                cmd.Parameters.AddWithValue("d", libelle);
                cmd.Parameters.AddWithValue("e", date);
                cmd.Parameters.AddWithValue("f", note);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "note inséré avec succès";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static List<Rapport> AfficherRapport(string filiere, string libelle)
        {
                //Rapport r ;
                List<Rapport> RList = new List<Rapport>();
            
             
             try
             {

                 OdbcCommand cmd = new OdbcCommand("select nom, prenom, note, datecompos from etudiant, evaluation, matiere where filiere=? and libelle=? and etudiant.id_etudiant=evaluation.id_etudiant and evaluation.id_matiere=matiere.id_matiere", getConnexion());

                 cmd.Parameters.AddWithValue("a", filiere);
                 cmd.Parameters.AddWithValue("b", libelle);
                 OdbcDataReader dr = cmd.ExecuteReader();

                 while (dr.Read())
                 {
                   Rapport r = new Rapport(dr.GetString(0), dr.GetString(1), dr.GetDouble(2), dr.GetString(3));
                   RList.Add(r);
                    // MessageBox.Show(dr.GetString(0), dr.GetString(1), dr.GetString(3));
                 }
                 cmd.Dispose();
                 return RList;
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
                 return RList;

             }
                
                
            
            
        }

        public static string AjouterMatiere(string libelle, int coef)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand("insert into matiere(libelle, coef) values(?,?)", getConnexion());
                cmd.Parameters.AddWithValue("a", libelle);
                cmd.Parameters.AddWithValue("b", coef);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "matiere inséré avec succès";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string Notes(string datecompos, double note, string filiere)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand("insert into evaluation(datecompos, note) values(?,?)", getConnexion());
                cmd.Parameters.AddWithValue("a", datecompos);
                cmd.Parameters.AddWithValue("b", note);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "matiere inséré avec succès";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}