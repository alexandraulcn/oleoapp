using Oleo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oleo.Data
{
    public static class OilData
    {
        public static IList<Oil> Oils { get; private set; }
        static OilData()
        {

            Oils = new List<Oil>();
         
            Oils.Add(new Oil
            {
                Nume = "Arbore de ceai",
                Descriere = "Busuiocul poate destinde mușchii inflamați sau încordați din cauza exercițiului fizic sau muncii. Are o aromă puternică, picantă ,care înviorează trupul și sufletul. Folosit extern poate înviora Spiritul și în caz de oboseală, poate reface limpezimea minții. Poate fi de asemenea folosit local, pentru a alina durerile cauzate de mușcături de insecte.Este benefic în caz de oboseală mentală și poate ajută la stimularea și dezvoltarea simțului mirosului.",
                Proprietati = "Uleiul esențial de busuioc este puternic antispasmodic, antiviral, antibacterian ,antiinflamator și relaxant muscular.",
                Indicatii = "migrene infecții ale gâtului, infecții pulmonare și mușcături de insecte.",
                Aplicare = "Se dilueaza o parte ulei esențial și o parte ulei vegetal. Se aplică 2-4 picături pe locul durerii, pe tâmple, gât, și pe punctele Vita Flex (craniu, frunte, inima și buric).Se recomandă inhalarea directă. Se recomandă vaporizarea și luarea că supliment alimentar.",
                Atentie = "Nu luați dacă sunteți epileptic!"
            });

            Oils.Add(new Oil
            {
                Nume = "Busuioc"
            });

            Oils.Add(new Oil
            {
                Nume = "Cedarwood",
                Descriere= "Uleiul esențial “Cedarwood” are o aromă plăcută de lemn de cedru. Împreună cu masajul,destinde și calmează și în plus, contribuie la menținerea unei funcționări sănătoase a plamânilor. Lemnul de cedrul este utilizat în mod uzual ca o componentă pentru produse cosmetice împotriva tenului gras. Lemnul de Cedru este ușor antiseptic, foarte eficient împotriva tuberculozei, bronșitei,infecțiilor urinare, foarte benefic problemelor pielii, cum ar fi acneea și psoriazisul și reduce rigidizarea pereților arterelor. De asemenea, ajută la stimulare glandei pineale, care produce melatonină, un hormon antioxidant asociat cu somnul profund. Lemnul de Cedru poate ajuta la acnee, anxietate, artrita, congestie, tuse, cistita, matreata,psoriazis, sistemul respirator, sinuzita, boli de piele și retentie de lichid. Stimulează creierul, centrul emoțiilor noastre, și este recunoscut pentru efectele sale calmante și purificatoare.",
                Proprietati= "Uleiul esențial de lemn de cedru combate căderea parului (alopecia areata), antibacterian și stimulant limfatic.",
                Indicatii= "Alzheimer, căderea parului, artroscleroza, ADHD ( deficit de atenție cauzat de hiperactivitate)",
                Aplicare= "Se aplică local și pe punctele Vita Flex. Se recomandă inhalarea directă. Se recomandă vaporizarea și administrarea ca supliment alimentar.",
                Atentie="Acest ulei nu prezintă atenționări. Nu uitați să diluați corect."
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
                Nume = "Cuișoare",
                Descriere= "Uleiul esențial de cuișoare are o nota aromatica dulce, picantă, care stimulează și invioreaza. Uleiul Esențial de Cuișoare este o componenta importantă în amestecul nostru “Thieves”, cunoscut mai ales prin efectul său de întărire a sistemului imunitar. Principalul element component al uleiului esențial de cuișoare este eugenolul, care se folosește în stomatologie pentru anestezierea gingiilor. Dintre toate substantele testate, uleiul esențial de cuișoare are valoarea cea mai înaltă pe scara ORAC (testează capacitatea de a reduce radicalii liberi). Aroma de cuișoare este un stimulator mental, ajută somnul, stimulează apariția viselor și creează o stare de protecție și inspiră curaj.",
                Proprietati= "Uleiul Esențial de Cuișoare este este anti-îmbatranire, antitumoral, antimicrobian, antifungic, antiviral, analgezic/anestezic, antioxidant, anticoagulant, anti-inflamator, protector pentru stomac ( contra ulcerului), antiparazitic (contra viermilor), anticonvulsiv.",
                Indicatii= "anti-îmbatranire, boli cardiovasculare, artrită/reumatism, hepatită, paraziți intestinali/infecții intestinale, folosit la amorțirea tuturor tipurilor de durere, infecții ORL/sinusuri/plaâni, cataracte, ulcere, păduchi, dureri dentare, acnee.",
                Aplicare= "Se aplică 2-4 picături local și pe punctele Vita Flex. Inhalarea directă este recomandata la fel și inhalarea uleiului vaporizat. Luarea ca supliment alimentar este recomandata.Pentru tusea seaca, uscata, din aceea care “gadila”,puneți o picătură la baza limbi.Atunci cand este folosit ca supliment alimentar este recomandata diluarea unei picături de ulei cu 120 ml de ulei vegetal înainte de a fi pusa in capsule.Se ia cate o capsula înainte de masa",
                Atentie= "Dacă luați medicamente pentru diluarea sangelui, întrebați întai medicul! Poate provoca iritații celor cu pielea sensibilă. Dacă sunteți însărcinată sau dacă va aflați sub control medical, consultați-vă medicul înainte de a folosi acest ulei. Diluați uleiul de cuișoare înainte de a-l aplica pe piele sau de a-l ingera. A nu se lăsa la îndemana copiilor!"
            });

            Oils.Add(new Oil
            {
                Nume = "Elemi"
            });

            Oils.Add(new Oil
            {
                Nume = "Eucalypt Albastru",
                Descriere= "Este un membru al familiei eucaliptului, eucaliptul se adaugă liniei de uleiuri esentiale ce provin din Ecuador. Metoda de extracție a uleiului este prin distilarea cu abur a frunzelor. Parfumul este proaspăt, echilibrat și revigorant.",
                Proprietati= "Uleiul de eucalipt este expectorant, promovează transpirația, îndepărtează insectele, promovează producerea estrogenului și imita efectul estrogenului, antifungic, antibacterian, calmant și revigorant.",
                Indicatii= "Susține funcțiile respiratori și promovează respiratia normala și calmează muschii durerosii.",
                Aplicare= "Se dilueaza o parte ulei esențial cu o parte ulei vegetal. Se recomanda aplicarea local si pe punctele Vita Flex. Se recomanda inhalarea directă a uleiului și inhalarea uleiului vaporizat. Se recomanda difuzarea uleiului pana la 30 min, de trei ori pe zi.",
                Atentie= "A nu se lăsa la indemana copiilor!Nu folosiți ca supliment alimentar,cantități mari de eucalipt,poate fi toxic! "
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
                Nume = "Mușețel roman",
                Descriere= "Uleiul esențial de mușețel român plăcută, dulce, picantă, cu acțiune calmantă pentru trup și spirit. Delicatețea musetelului îl face deosebit de prețios pentru copii agitați. Uleiul Esențial de Mușețel este calmant pentru toate tipurile de piele, folosit tot mai intens în Europa în preparate pentru piele, pentru tineri și bătrâni. Acest ulei esențial are efect excepțional prin adăugarea într-un ulei de masaj, pentru musculatura solicitată de efortul din activitatea sportivă.Pentru a amplifică efectul de relaxare combinați cu lavandă.",
                Proprietati= "Uleiul esențial de mușețel este un relaxant nervos, antispasmodic, anti-inflamator, antiparazitar, regenerant nervos, anestezic, detoxifiant pentru organism și ficat. ",
                Indicatii= "Atenuează stările de neliniște, anxietatea, ADHD-ul, depresia, insomnia, afecțiunile dermatologice (acnee, dermatita, eczeme), probleme digestive, simptome premenstruale, șocuri emoționale, suferință",
                Aplicare= "Se aplică 2-4 picături ulei esențial local, pe glezne, pe încheieturi și pe punctele Vita Flex de pe talpă. Se recomandă inhalarea directă sau prin vaporizare. Se recomandă consumarea că supliment alimentar în lapte de soia sau de orez. ",
                Atentie= "Acest ulei nu prezintă atenționări. Nu uitați să diluați corect."
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
                Nume = "Salvie Tămâioasă",
                Descriere= "Uleiul esențial de salvie conține fitoestrogeni naturali. Aromă este moale și caldă, destinde și înviorează, și astfel sprijină o atitudine interioară sănătoasă, în timpul simptomului premenstrual. Este de ajutor pentru femeile la menopauza. Ajută la menținerea funcționării sănătoase a sistemului digestiv și a sistemului circulator. Parfumul sau accentuează capacitatea de a visa, este foarte calmant și te eliberează de stres.",
                Proprietati= "Uleiul esențial de salvie este un anticoagulant, antioxidant, antidiabetic, mimează efectele estrogenilor, antifungic, antispasmodic, relaxant, reduce nivelul colesterolului, antitumoral, anestezic.Date medicale recente indică faptul că salvia crește în mod natural nivelul de estrogen și progesteron.",
                Indicatii= "leucemie, dureri menstruale/probleme asociate PMS(sindromul premenstrual), premenopauza, dezechilibrul hormonal, probleme cu circulația,  colesterol ridicat, bronșită, hemoroizi, impotența, probleme renale, căderea părului.",
                Aplicare= "Se diluează o parte ulei esențial cu o parte ulei vegetal.Se aplică local, pe picioare, glezne, încheieturi și pe punctele Vita Flex/chakra.Se recomandă inhalarea directă sau vaporizarea.Se recomandă luarea că supliment alimentar.Se face masaj pe spate cu 6-8 picături în perioada premergătoare menstruației.",
                Atentie= "Poate provoca iritații celor cu pielea sensibilă.Dacă sunteți însărcinată sau dacă va aflați sub control medical, consultați-vă medicul înainte de a folosi acest ulei. Diluați uleiul esențial de salvie înainte de a-l folosi în zone sensibile precum fața, gâtul, zona genitală etc. A nu se lăsa la îndemâna copiilor ! Nu folosiți uleiul de salvie pe copii sau pe bebeluși!"

            });

            Oils.Add(new Oil
            {
                Nume = "Salvie"
            });

            Oils.Add(new Oil
            {
                Nume = "Scorțișoară",
                Descriere= "Uleiul Esențial de Scorțișoară are o aromă minunată de scorțișoară, îndrăgita pretutindeni. Mai ales în anotimpul are un efect de încălzire și stimulare. Multora, această aromă li se pare foarte romantică. De-a lungul istoriei, scorțișoară a fost atât de căutată și dorită, încât a construit unul dintre principalele motive pentru care Ceylon a fost cucerit mai întâi de portughezi, iar apoi de olandezi și mai târziu de englezi. Acolo, uleiul esențial de scorțișoară se produce de peste 2000 de ani.",
                Proprietati= "Uleiul esențial de scorțișoară este un anti-inflamator (inhibitor COX2), puternic antibacterian, antiviral, antifungic, anticoagulant, stimulant pentru circulație, protector al stomacului (în caz de ulcer), antiparazitar (viermi).",
                Indicatii= "afecțiuni cardiovasculare, boli infecțioase, infecții virale ( herpes), probleme digestive, ulcere negi.",
                Aplicare= "Se diluează o parte ulei esențial cu patru părți ulei vegetal.Se aplică 1-2 picături local și pe punctele Vita Flex/chakre.Se recomandă inhalarea prin vaporizare sau luarea că supliment alimentar.",
                Atentie= "Poate irita membranele nazale dacă se inhaleaza direct din aparat de vaporizare sau sticlă!"
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


