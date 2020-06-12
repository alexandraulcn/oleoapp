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
                Descriere = "În timpul unei crize de astm, căile respiratorii pulmonare se umflă și se înfundă cu mucus gros și lipicios. mușchii căilor respiratorii încep să se contracteze sau să se strângă. Lucrul acesta poate duce la o respirație foarte groaie. Dacă criza este foarte gravă, poate fi amenințată chiar viață. Multe crize de astm sunt declanșate de o reacție alergica la polen, la particule de praf, păr de pisică sau câine, precum și de la alte alimente precum ouă, lapte, coloranți sau alte chimicale.Astmul mai poate fi declanșat și de infecții respiratorii, stres și factori psihologici.",
                Recomandari = "eucalyptus(E. radiata), frankincense, eucalyptus blue, ravintsara, palo santo, R.C",
                Aplicare = "Pentru inhalare, pulverizați timp de 3-5 minute un ulei la alegere, puneți 2-3 picături dintr-un ulei în palme și țineți-le la nas, inhalând pe parcursul zilei la nevoie. Mai puteți aplica extern 1-2 picături pe tâmple și pe spatele gâtului, după dorință."
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Arsuri de gradul I (arsuri solare)",
                Descriere = "Cea mai eficientă metodă de prevenire a arsurilor solare este evitarea expunerii prelungite la soare.Când ieșiți afară, purtați intotdeanu obiecte care vă protejează și folosiți loțiuni cu factori de protecție mai mare de 15.",
                Recomandari = "spikenard, lavender, helichrysum, rose, german chamomile, melrose, valor",
                Aplicare = "Pentru o vindecare rapidă a arsurilor de gradul I, răcoriți zona afectată. Aplicați 1-3 picături de ulei simplu sau diluat 50/50 pe locul arsurii pentru a răci țesăturile și a reduce inflamarea. Aplicați de 3-6 ori pe zi sau la nevoie."
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Arsuri la stomac",
                Descriere = "Sucul de lămâie este unul dintre cele mai bune remedii pentru arsurile la stomac. Amestecați sucul de la o jumătate de lămâie stoarsă cu un pahar de apă și beți încet dimineața la trezire. Sucul de lămâie ajută stomacul să nu mai producă acid, prin urmare atenuează arsurile sau alte afecțiuni ale stomacului.",
                Recomandari = "spearmint, ginger, lemon, cypress, tarragon, fennel, Di-Gize",
                Aplicare = "Rețetă pentru arsuri la stomac: 2 picături basil, 1 picătură Idaho tansy, 8 picături sage, 3 picături sandalwood. Aplicați o compresă caldă pe stomac, 1-3 picături de ulei recomandat sau din rețetă. Diluați 50/50 și aplicați local de 3-6 pe zi. De asemenea, luați o capsulă cu unul dintre uleiurile recomandate, de 2 ori pe zi. "
            });

            Afectiuni.Add(new Afectiune
            {
                Denumire = "Balonare",
                Descriere = "Balonarea este o tulburare gastrointestinală ce se întâlnește atât la adulți, cât și la copii. În termeni medicali ea poartă numele de meteorism abdominal și este provocat de o masă prea bogată, de consumul de dulciuri și anumite alimente, cât și de tulburări hormonale sau stres. Există, însă, și cazuri în care acest disconfort poate ascunde boli grave, așa că nu trebuie să o tratați cu indiferentă.",
                Recomandari = "juniper, clary sage, cypress, peppermint, fennel, nutmeg, di-gize",
                Aplicare = "Cantitatea de ulei înghițit depinde de la ulei la ulei. Adăugați câteva picături din uleiurile recomandate într-un lichid și beți zilnic. Luați o capsulă de peppermint de 3 ori pe zi."
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
