using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Oleo.Models;

namespace Oleo.ViewModels
{
    class AfectiuneListViewModel
    {
        public List<Afectiune> Afectiuni { get; set; }
        public AfectiuneListViewModel()
        {
            Afectiuni = new List<Afectiune>();
            /*Afectiuni.Add(new Afectiune
            {
                Denumire = "",
                Descriere = "",
                Recomandari = "",
                Aplicare = ""
            })*/
            Afectiuni.Add(new Afectiune
            {
                Denumire = "Acnee"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Antiseptic"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Astm",
                Descriere = "In timpul unei crize de astm, caile respiratorii pulmonare se umfla si se infunda cu mucus gros si lipicios. muschii cailor respiratorii incep sa se contracteze sau sa se stranga. Lucrul acesta poate duce la o respiratie foarte groaie. Daca criza este foarte grava, poate fi amenintata chiar viata. Multe crize de astm sunt declansate de o reactie alergica la polen, la particule de praf, par de pisica sau caine, precum si de la alte alimente precum oua, lapte, coloranti sau alte chimicale.Astmul mai poate fi declansat si de infectii respiratorii, stres si factori psihologici.",
                Recomandari = "eucalyptus(E. radiata), frankincense, eucalyptus blue, ravintsara, palo santo, R.C",
                Aplicare = "Pentru inhalare, pulverizati timp de 3-5 minute un ulei la alegere, puneti 2-3 picaturi dintr-un ulei in palme si tineti-le la nas, inhaland pe parcursul zilei la nevoie. Mai puteti aplica extern 1-2 picaturi pe tample si pe spatele gatului, dupa dorinta."
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Arsuri de gradul I (arsuri solare)",
                Descriere = "Cea mai eficienta metoda de prevenire a arsurilor solare este evitarea expunerii prelungite la soare.Cand iesiti afara, purtati intotdeanu obiecte care va protejeaza si folositi lotiuni cu factori de protectie mai mare de 15.",
                Recomandari = "spikenard, lavender, helichrysum, rose, german chamomile, melrose, valor",
                Aplicare = "Pentru o vindecare rapida a arsurilor de gradul I, racoriti zona afectata. Aplicati 1-3 picaturi de ulei simplu sau diluat 50/50 pe locul arsurii pentru a raci tesaturile si a reduce inflamarea. Aplicati de 3-6 ori pe zi sau la nevoie."
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Arsuri la stomac",
                Descriere = "Sucul de lamaie este unul dintre cele mai bune remedii pentru arsurile la stomac. Amestecati sucul de la o jumatate de lamaie stoarsa cu un pahar de apa si beti incet dimineata la trezire. Sucul de lamaie ajuta stomacul sa nu mai produca acid, prin urmare atenueaza arsurile sau alte afectiuni ale stomacului.",
                Recomandari = "spearmint, ginger, lemon, cypress, tarragon, fennel, Di-Gize",
                Aplicare = "Reteta pentru arsuri la stomac: 2 picaturi basil, 1 picatura Idaho tansy, 8 picaturi sage, 3 picaturi sandalwood. Aplicati o compresa calda pe stomac, 1-3 picaturi de ulei recomandat sau din reteta. Diluati 50/50 si aplicati local de 3-6 pe zi. De asemenea, luati o capsula cu unul dintre uleiurile recomandate, de 2 ori pe zi. "
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Balonare",
                Descriere= "Balonarea este o tulburare gastrointestinală ce se întâlnește atât la adulți, cât și la copii. În termeni medicali ea poartă numele de meteorism abdominal și este provocat de o masă prea bogată, de consumul de dulciuri și anumite alimente, cât și de tulburări hormonale sau stres. Exista, însă, și cazuri în care acest disconfort poate ascunde boli grave, așa că nu trebuie să o tratați cu indiferentă.",
                Recomandari="juniper, clary sage, cypress, peppermint, fennel, nutmeg, di-gize",
                Aplicare= "Cantitatea de ulei înghițit depinde de la ulei la ulei. Adăugați câteva picături din uleiurile recomandate într-un lichid și beți zilnic. Luați o capsulă de peppermint de 3 ori pe zi."
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Dureri de articulații"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Dureri de cap"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Dureri de gât"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Febră"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Greață"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Indigestie"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Infecții ale gâtului"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Infecții ale urechiilor"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Insomnie"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Înțepături de insecte"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Mușchi inflamați"
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Sângerări"
            });


        }

    }
}
