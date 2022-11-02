/*
De generische klasse Stapel met volgende eigenschappen:
De interne (private) container is gebaseerd op een List
De publieke methoden 
Toevoegen (iets) : zet een generisch object op de stapel
iets Verwijderen() : haal een generisch object van de stapel en return dit aan de oproeper
void Leegmaken() : haal alles van de stack
string ToString () : als override van de bestaande ToString die de hele inhoud van de stack weergeeft in een string
bool IsAanwezig (iets) : een booleaanse methode die true is als een gegeven generisch object ergens in de stack voorkomt
Stapel Copy () : maak een "shallow" kopij van een stapel naar een nieuwe stapel
Hint:  Zoek voor jezelf het verschil op tussen een shallow en een deep copy
Gebruik de methode MemberwiseClone()
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    
    internal class Stapel<T>
    {
        List<T> stapel = new List<T>();
        List<T> stapelcopy = new List<T>();

        //string Appel = new string();
        //int numbers = new int();


        public void Toevoegen(T toevoegen)
        {
            stapel.Add(toevoegen);
        }

        public T Verwijderen()
        {
            if (stapel.Count > 0)
            {
                throw new ArgumentNullException();
            }

            T newStapel = stapel[stapel.Count - 1];
            stapel.RemoveAt(stapel.Count - 1);

            return newStapel;

        }

        public void Leegmaken()
        {
            stapel.Clear();
        }

        public string ToString(string s)
        {
            s = s.Trim();
            return s; //Elk object heeft een toString
        }

        public bool isAanwezig(T zoeken)
        {
            return stapel.Contains(zoeken);
        }

        public Stapel<T> listCopy()
        {
            stapelcopy= stapelcopy.GetRange(0, stapel.Count);

            return (Stapel<T>)this.MemberwiseClone();
        }


    }

    //class ShallowCopy
    //{

    //}
}
