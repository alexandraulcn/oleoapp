using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;
using Oleo.Models;

namespace Oleo.ViewModels
{
    class OilListViewModel : BaseViewModel
    {
        public ObservableCollection<Oil> _oils;
        public ObservableCollection<Oil> Oils
        {
            get { return _oils; }
            set
            {

                _oils = value;
            }
        }
        public OilListViewModel()
        {

            Oils = new ObservableCollection<Oil>();
            /*Oils.Add(new Oil
            {
                Nume = "",
                Descriere = "",
                Proprietati = "",
                Indicatii = "",
                Aplicare = "",
                Atentie = ""
            })*/

            Oils.Add(new Oil
            {
                Nume = "Arbore de ceai"
            });

            Oils.Add(new Oil
            {
                Nume = "Busuioc"
            });

            Oils.Add(new Oil
            {
                Nume = "Cedarwood"
            });

            Oils.Add(new Oil
            {
                Nume = "Cimbru"
            });

            Oils.Add(new Oil
            {
                Nume = "Copaiba"
            });

            Oils.Add(new Oil
            {
                Nume = "Cuișoare"
            });

            Oils.Add(new Oil
            {
                Nume = "Elemi"
            });

            Oils.Add(new Oil
            {
                Nume = "Eucalyptus Blue"
            });

            Oils.Add(new Oil
            {
                Nume = "Eucalyptus Globulus"
            });

            Oils.Add(new Oil
            {
                Nume = "Eucalyptus Radiata"
            });

            Oils.Add(new Oil
            {
                Nume = "Ghimbir"
            });

            Oils.Add(new Oil
            {
                Nume = "Grapefruit"
            });

            Oils.Add(new Oil
            {
                Nume = "Imortele"
            });

            Oils.Add(new Oil
            {
                Nume = "Lavandă"
            });


            Oils.Add(new Oil
            {
                Nume = "Lămâie",
                Descriere = "Uleiul esențial de lămâie are o aromă de lămâie intensă, proaspătă, purificatoare, care înviorează și ridică dispoziția. Limpezește mintea sau gândurile, datorită parfumului său revigorant. Cercetătorii universitari din Japonia au descoperit că vaporizarea anumitor miresme la birou îmbunătățesc puterea de concentrare și limpezimea în gândire. Parfumul de lămâie vaporizat într-un asemenea mediu a dus la o scădere cu 54% a erorilor făcute. De asemenea, în urma unui studiu realizat în 1995 efectuat de Universitatea Mie, s-a descoperit că aromele de citrice îmbunătățesc imunitatea, determină o stare de relaxare și elimină depresia. Se compune în proporție de 68 % din d - limonene, o substanță cu efect puternic antioxidant.Pentru a produce 1kd de ulei, este nevoie de 3000 de lămâi.",
                Proprietati = "Uleiul esențial de lămâie este o sursă de vitamine și minerale mai mare ca orice alt aliment, are capacitatea de a curăța toxinele din orice parte a corpului. Asta include părul, scalpul, sistemul digestiv, rinichii. Are efect antifungic, antibacterian, antiviral, imunostimulant, diuretic, digestiv, calmant. ",
                Indicatii = "probleme ale părului, acnee, seboree, probleme ale pielii, pentru detoxifierea ficatului și a rinichiilor, paraziți, anxietate,insomnie",
                Aplicare = "Se diluează 1 picătură ulei esențial cu 1 picătură ulei vegetal. Se aplică 2-4 picături local în punctele Vita Flex. Uleiul se poate difuza sau inhala direct, iar ca supliment alimentar o picătură pe o linguriță de miere. Este foarte recomandat pentru a tine insectele la distanta și util pentru a curățarea și dezinfectarea suprafețelor și a obiectelor casnice.",
                Atentie = "A se evita aplicarea pe pielea care va fi expusă la soare sau raze UV în următoarele 12 ore."
            });

            Oils.Add(new Oil
            {
                Nume = "Lemongrass (citronella)"
            });

            Oils.Add(new Oil
            {
                Nume = "Mandarine"
            });

            Oils.Add(new Oil
            {
                Nume = "Mentă (peppermint)",
                Descriere = "Uleiul esențial de mentă are o aromă proaspătă, purificatoare, de mentă. Ca una dintre cele mai vechi și larg cunoscute ierburi, cu acțiune de calmare asupra sistemului digestiv, contribuie la funcționarea generală bună a digestiei. Parfumul său are efect stimulant și purificator asupra conștientului uman.  Menta blochează durerile de cap și reduce friciile legate de mișcare. Dr. William N. Dember de la Universitatea din Cincinnati a descoperit că inhalarea uleiului de mentă crește cu 28% puterea de concentrare. De asemenea, Dr. Alan Hirsch a studiat menta și a descoperit că are puterea de a stimula centrul sațietății la nivelul creierului în scopul de a tăia pofta de mâncare.",
                Proprietati = "Uleiul este anti-inflamator, antiparazitic, antibacterian, antiviral, antifungic, stimulant al vezicii biliare, stimulant digestiv, calmează durerea și reduce apetitul.",
                Indicatii = "reumatism, artrită, infecții ale căilor respiratorii (pneumonie, tuberculoză, etc.), infecții virale (Herpes simplex, herpes bucal), infecții fungice/Candida, probleme digestive, dureri de cap, greață, probleme dermatologice (piele care te mănâncă, varice, eczeme, dermatite), scolioză/dureri de spate",
                Aplicare = "Se diluează 1 picătură ulei esențial cu 1 picătură ulei vegetal. Se aplică 2-4 picături local. Pentru probleme respiratorii acesta se poate inhala direct sau administrat prin vaporizare. Se ia că supliment alimentar (se diluează o picătură de ulei esențial în aproximativ 120 ml de lichid). Pentru a ameliora puterea de concentrare, vigilența, promptitudinea și memoria, puneți 1-2 picături pe limbă. Inhalați de 5-10 ori pe zi pentru a ține în frâu pofta de mâncare.",
                Atentie = "A se evita contactul cu ochii, membranele mucoase, pielea sensibilă sau arsurile ori rănile recente. A nu se aplica copiilor sub 18 luni."
            });

            Oils.Add(new Oil
            {
                Nume = "Mentă verde (spearmint)"
            });

            Oils.Add(new Oil
            {
                Nume = "Mirt"
            });

            Oils.Add(new Oil
            {
                Nume = "Mușețel roman"
            });

            Oils.Add(new Oil
            {
                Nume = "Nucșoară"
            });

            Oils.Add(new Oil
            {
                Nume = "Oregano"
            });

            Oils.Add(new Oil
            {
                Nume = "Piper negru"
            });

            Oils.Add(new Oil
            {
                Nume = "Portocală"
            });

            Oils.Add(new Oil
            {
                Nume = "Rozmarin"
            });

            Oils.Add(new Oil
            {
                Nume = "Salvie Tămâioasă"
            });

            Oils.Add(new Oil
            {
                Nume = "Salvie"
            }); 

            Oils.Add(new Oil
            {
                Nume = "Scorțișoară"
            });

            Oils.Add(new Oil
            {
                Nume = "Tămâie"
            });

            Oils.Add(new Oil
            {
                Nume = "Valeriană"
            });

            Oils.Add(new Oil
            {
                Nume = "Ylang Ylang"
            });
        }
    }
}

