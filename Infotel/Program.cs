// See https://aka.ms/new-console-template for more information

static string functionDemanderNom(int numeroDeLaPersonne)
{
    string nom = "";

    while (nom == "")
    {
        Console.WriteLine("Entrez le prénom de la personne numéro " + numeroDeLaPersonne);
        nom = Console.ReadLine();
        nom = nom.Trim();
        if (nom == "")
        {
            Console.WriteLine("le prénom ne doit pas être vide");
        }

    }
    return nom;
}
    static int functionDemanderAge(string nom)
    {
        int age_num = 0;
        while (age_num <= 0)
        {
            Console.WriteLine("Entrez votre âge " + nom);
            string age_str = Console.ReadLine();

            try
            {
                age_num = int.Parse(age_str);
                if (age_num <= 0)
                {
                    Console.WriteLine("L'âge ne doit pas être négatif ou égal à zéro");
                }

            }
            catch
            {
                Console.WriteLine("Erreur, veuillez entrer un âge valide");
            }
        }
    return age_num;
}

static void functionAfficherInfos(string nom, int age, float taille = 0)
{
    Console.WriteLine("Salut " + nom + ", tu as " + age + " ans.");
    Console.WriteLine("Bientôt tu auras " + (age + 1) + " ans.");
    //si age >= 18 = majeur
    //si age == 17 vous serez bientot majeur
    //si age == 18 vous etes tout juste majeur
    //si age >= 60 senior
    //si age < 10 enfant
     if ((age ==1 ) || (age ==2))
    {
        Console.WriteLine("Vous etes un bébé");
    }
    else if(age <10)
    {
        Console.WriteLine("Vous êtes un enfant");
    }
    else if (age >= 60)
    {
        Console.WriteLine("Vous êtes senior");
    }
    else if(age == 17)
    {
        Console.WriteLine("Vous serez bientôt majeur");
    }
    else if (age == 18)
    {
        Console.WriteLine("Vous êtes tout juste majeur");
    }
    else if ((age >= 12)&&(age<18 ))
    {
        Console.WriteLine("Vous êtes adolescent");
    }
    else if (age >= 18)
    {
        Console.WriteLine("Vous êtes majeur");
    }
    else
    {
        Console.WriteLine("Vous êtes mineur");
    }
     if(taille != 0)
    {
        Console.WriteLine("Vous faites " + taille + " m de hauteur");
    }
  
}

float taille = 1.75f;

string nom1 = functionDemanderNom(1);
string nom2 = functionDemanderNom(2);
int age1 = functionDemanderAge(nom1);
int age2 = functionDemanderAge(nom2);
functionAfficherInfos(nom1, age1, taille);
functionAfficherInfos(nom2, age2);
Console.WriteLine($"Merci d'avoir participé {nom1} et {nom2}");


//Console.WriteLine();
//Console.WriteLine("Salut " + nom1 + ", tu as " + age1 + " ans.");

//    Console.WriteLine("Bientôt tu auras " + (age1+1) + " ans.");

//Console.WriteLine();
//Console.WriteLine("Salut " + nom2 + ", tu as " + age2 + " ans.");

//Console.WriteLine("Bientôt tu auras " + (age2 + 1) + " ans.");

//const int NB_PERSONNES = 3;

//for(int i = 0; i < NB_PERSONNES; i++)
//{
//    int nom = (i + 1);
//    string prenom = functionDemanderNom(nom);
//    int age = functionDemanderAge(prenom);
//    functionAfficherInfos(prenom, age);
//    Console.WriteLine("--");
//}






