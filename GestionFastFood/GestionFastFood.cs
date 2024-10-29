using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionFastFood
{
    public class GestionFastFood
    {
        class Client
        {
            public int id;

            public int Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }

            public string nom;
            public string Nom
            {
                get
                {
                    return this.nom;
                }
                set
                {
                    this.nom = value;
                }
            }

            public string prenoms;
            public string Prenoms
            {
                get
                {
                    return this.prenoms;
                }
                set
                {
                    this.prenoms = value;
                }
            }


            public string contact;
            public string Contact
            {
                get
                {
                    return this.contact;
                }
                set
                {
                    this.contact = value;
                }
            }



            public Client(int id, string nom, string prenoms, string contact)
            {
                this.id = id;
                this.nom = nom;
                this.prenoms = prenoms;
                this.contact = contact;
            }

            // Méthode pour afficher les informations du client
            public void informationsClients()
            {
                Console.WriteLine("Nom: " + nom);
                Console.WriteLine("Prenoms: " + prenoms);
                Console.WriteLine("Contact: " + contact);
            }
        }

        class Plats
        {
            public string plats;

            public string Plat
            {
                get
                {
                    return this.plats;
                }
                set
                {
                    this.plats = value;
                }
            }


            public double prix;
            public double Prix
            {
                get
                {
                    return this.prix;
                }
                set
                {
                    this.prix = value;
                }
            }


            public Plats(string plats, double prix)
            {
                this.plats = plats;
                this.prix = prix;
            }

            // Méthode pour afficher les informations du plat
            public void afficherPlat()
            {
                Console.WriteLine("Plat: " + plats + ", Prix: " + prix);
            }
        }

        class Menu
        {
            public string platsMenu;

            public string PlatsMenu
            {
                get
                {
                    return this.platsMenu;
                }
                set
                {
                    this.platsMenu = value;
                }
            }



            public double prix;
            public double Prix
            {
                get
                {
                    return this.prix;
                }
                set
                {
                    this.prix = value;
                }
            }

            public string heureDeDisponibiliteDuPlats;
            public string HeureDeDisponibiliteDuPlats
            {
                get
                {
                    return this.HeureDeDisponibiliteDuPlats;
                }
                set
                {
                    this.HeureDeDisponibiliteDuPlats = value;
                }
            }

            public Menu(string platsMenu, double prix)
            {
                this.platsMenu = platsMenu;
                this.prix = prix;
            }

            // Méthode pour afficher les informations du menu
            public void afficherMenu()
            {
                Console.WriteLine("Menu: " + platsMenu + ", Prix: " + prix);
            }
        }

        class Commande
        {
            public string platsCommande;
            public string PlatsCommande
            {
                get
                {
                    return this.platsCommande;
                }
                set
                {
                    this.platsCommande = value;
                }
            }



            public double prixTotalCommande;
            public double PrixTotalCommande
            {
                get
                {
                    return this.prixTotalCommande;
                }
                set
                {
                    this.prixTotalCommande = value;
                }
            }




            public Commande(string platsCommande, double prixTotalCommande)
            {
                this.platsCommande = platsCommande;
                this.prixTotalCommande = prixTotalCommande;
            }

            // Méthode pour afficher les informations de la commande
            public void afficherCommande()
            {
                Console.WriteLine("Plats commandés: " + platsCommande);
                Console.WriteLine("Prix total de la commande: " + prixTotalCommande);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Demander les informations du client à l'utilisateur
                Console.WriteLine("Entrez les informations du client :");
                Console.Write("ID : ");
                int idClient = Int32.Parse(Console.ReadLine());
                Console.Write("Nom : ");
                string nomClient = Console.ReadLine();
                Console.Write("Prenoms : ");
                string prenomsClient = Console.ReadLine();
                Console.Write("Contact : ");
                string contactClient = Console.ReadLine();

                // Création du client avec les informations récupérées
                Client client = new Client(idClient, nomClient, prenomsClient, contactClient);

                // Affichage des informations du client
                Console.WriteLine("\nInformations du client :");
                client.informationsClients();

                // Demander les informations du plat à l'utilisateur
                Console.WriteLine("\nEntrez les informations du plat :");
                Console.Write("Nom du plat : ");
                string nomPlat = Console.ReadLine();
                Console.Write("Prix du plat : ");
                double prixPlat = Double.Parse(Console.ReadLine());

                // Création du plat avec les informations récupérées
                Plats plat = new Plats(nomPlat, prixPlat);

                // Affichage des informations du plat
                Console.WriteLine("\nInformations du plat :");
                plat.afficherPlat();

                // Demander les informations du menu à l'utilisateur
                Console.WriteLine("\nEntrez les informations du menu :");
                Console.Write("Nom du menu : ");
                string nomMenu = Console.ReadLine();
                Console.Write("Prix du menu : ");
                double prixMenu = Double.Parse(Console.ReadLine());

                // Création du menu avec les informations récupérées
                Menu menu = new Menu(nomMenu, prixMenu);

                // Affichage des informations du menu
                Console.WriteLine("\nInformations du menu :");
                menu.afficherMenu();

                // Demander les informations de la commande à l'utilisateur
                Console.WriteLine("\nEntrez les informations de la commande :");
                Console.Write("Plats commandés : ");
                string platsCommande = Console.ReadLine();
                Console.Write("Prix total de la commande : ");
                double prixTotalCommande = Double.Parse(Console.ReadLine());

                // Création de la commande avec les informations récupérées
                Commande commande = new Commande(platsCommande, prixTotalCommande);

                // Affichage des informations de la commande
                Console.WriteLine("\nInformations de la commande :");
                commande.afficherCommande();
            }
        }
    }
}