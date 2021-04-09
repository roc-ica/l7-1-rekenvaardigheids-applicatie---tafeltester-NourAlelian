using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TafelTester_Nour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum Level
        {
            Level1,
            Level2,
            Level3
        }

        private int element = 0;
        private string LevelSelec = null;
        string[,] Opgaves =
        {
            { "Level1", @"White.png",
                "240 : ¾ =",
              "320"
            },
            { "Level1", @"White.png",
                "6,07 + 8,15 + 2,7 =",
               "16,92"
            },
            { "Level1", @"White.png",
             "512 x 12 - 256 x 4 =",
              "5120"
            },
            { "Level1", @"White.png",
              "15 - 45 : 3 x ⅔",
              "5"
            },
            { "Level1", @"Foto5.png",
              "Je moet 9 km fietsen van je huis naar je opleiding.\n" +
             "Je broertje fietst de eerste 2,5 km mee.\n" +
             "Daar doen jullie 10 minuten over. \n" +
             "Je fietst in hetzelfde tempo door naar je opleiding. \n" +
             "Je vertrekt om 8.15 uur. \n" +
             "Hoe laat kom je aan? \n" + "\n" +
             "HINT: Schrijf de tijd op deze manier: 03:22",
             "08:51"
            },
            { "Level1", @"Foto6.png",
               "Je organiseert een feest met optredens.\n" +
               "De opbrengst is voor een goed doel.\n" +
               "Je wilt daarom minstens € 10.000 overhouden. \n" +"\n" +
               "Hoe hoog moet de entreeprijs minstens zijn?",
              "19,70"
            },
            { "Level1",  @"Foto7.png",
                "Je bezorgt met je broertje de kranten. \n" +
                "Jij doet in je eentje 1 uur en 24 minuten over het bezorgen van de kranten. \n" +
                "Hoe lang doen jullie er over als jullie samen de kranten bezorgen? \n" + "\n" + 
                "Rond af op hele minuten.",
              "47"
            },
            { "Level1", @"Foto8.png",
                "In juni bel je 114 minuten, waarvan 6 minuten in het buitenland. \n" +
                "In het buitenland word je ook 18 minuten gebeld. \n" +
                "Je verstuurt 118 sms'jes waarvan 27 vanuit het buitenland. \n" + "\n" +
                "Wat zijn de totale kosten voor de maand juni?" ,
              "34,15"
            },
            { "Level1", @"White.png",
                "Je doucht gemiddeld 10 minuten per dag met een waterverbruik van gemiddeld 63,9 liter per keer. \n " +
                "Het watertarief is € 1,03 per m3. \n" + "\n" +
                "Hoeveel bespaar je per jaar als je dagelijks één minuut minder doucht? \n" +
                "Ga uit van 365 dagen.",
              "2,40"
            },
            {   "Level1", @"Foto10.png",
                "Bij een supermarkt worden per 1 januari geen gratis doorzichtige tasjes bij de kassa meer verstrekt; alleen als er naar gevraagd wordt.\n " +
                "Een rol plastic tasjes weegt 718 gram, inclusief kartonnen koker van 35 gram. \n" + "\n" +
                "Hoeveel kilo plastic bespaart de supermarkt gemiddeld per dag, sinds 1 januari? \n" +
                "Rond af op één decimaal.",
              "2,6"
            },


            //==========================================================================================


            {   "Level2", @"Foto11.png",
                "Je werkt bij een cateraar en organiseert een receptie voor 120 gasten.\n " +
                "Sterke drank is op voorraad, frisdrank en bier moet je inkopen. \n" + "\n" +
                "Je weet uit ervaring: \n" +
                "30% van de gasten drinkt alleen fris, 60% alleen bier en de rest drinkt een mixdrankje. \n" +
                "De gasten krijgen elk drie consumptiebonnen. \n" + 
                "Standaard hoeveelheden(Kijk foto) \n" + "\n" +
                "Hoeveel literflessen fris moet je minimaal inkopen?",
              "35"
            },
            { "Level2", @"Foto12.png",
                "Bij het begin van de barbecue ligt het vlees buiten op tafel. Het is 20 graden Celsius. Er zitten dan 500 bacteriën per cm2 op het vlees. \n " +
                "Hoeveel bacteriën zitten er na 2,5 uur ongeveer op één cm2?",
              "500000"
            },
            { "Level2", @"Foto13.png",
                "Je gaat drie weken op vakantie. Tijdens je vakantie wil je bepaalde tv-programma's automatisch laten opnemen. Eerst moet je ruimte maken op de harde schijf van je dvd-recorder. \n " +
                "Hoeveel uur ruimte moet je minimaal hebben op je harde schijf? \n " +
                "Rond af op hele uren.",
              "25"
            },
            { "Level2", @"White.png",
               "(24 x 6,8) : (6,8 x 4) = ..",
              "6"
            },
            { "Level2", @"White.png",
              "3,6 + 3,6 : 3,6 = .." ,
              "4,6"
            },
            { "Level2", @"White.png",
              "300 : 6 x (5 - 2)",
              "150"
            },
            { "Level2", @"White.png",
              "Je ouders zijn een jaar geleden in een nieuw huis gaan wonen. Het oude huis staat te koop. \n" + "\n" +
              "Ze betalen maandelijks € 872 aan rente en andere kosten voor het oude huis.  \n" + "\n" +
               "11 maanden geleden hebben ze een bod gehad van € 180.000. Dat vonden ze toen veel te weinig. Nu krijgen ze een bod van € 185.000. Ze accepteren dit bod.\n" + "\n" +
               "Als ze het eerste bod hebben geaccepteerd, hoeveel meer hadden je ouders dan gehad?",
              "4592"
            },
            { "Level2", @"foto14.png",
              "In de vakantie val je één keer in als postbezorger. \n" +
              "In week 30 ben je in totaal 2 uur en 10 minuten bezig. \n" + "\n" +
              "Hoeveel was je gemiddelde vergoeding per uur voor dit werk?",
              "8,34"
            },
            { "Level2", @"foto15.png",
              "Een groot containerschip kan 3.000 containers vervoeren. Aan de kade in Rotterdam wordt het schip met drie kranen tegelijk in 24 uur volgeladen. \n" + "\n" +
              "Hoeveel seconden duurt gemiddeld het laden van één container? \n" ,
              "86,4"
            },
            { "Level2", @"foto16.png",
              "Je koopt schuimplastic voor nieuwe kussens op vier stoelen en een bank. \n" + "\n" +
              "Schuimplastic kost ? 0,05 per 100 cm³. \n" +
              "Hoeveel kost het schuimplastic in totaal? \n",
              "21,17"
            },


             //==========================================================================================


            { "Level3", @"foto17.png",
              "Top 5 meest bekeken programma's deze week(Zie foto). \n" +
               "Het programma Voice of Holland bestaat uit twee delen. Het onderdeel 'Live' en het onderdeel 'The Results'.\n" +
               "Met hoeveel procent is het aantal kijkers afgenomen als je 'Live' vergelijkt met 'The Results'? \n" + "\n" +
               "Rond af op één decimaal.",
              "37,3"
            },
            { "Level3", @"foto18.png",
              "Hoeveel e-mails werden er gemiddeld per dag verstuurd in 2010 door iedere gebruiker, als je de e-mails met spam niet meetelt?",
              "17"
            },
            { "Level3", @"foto19.png",
              "Gegevens benzineverbruik afgelopen jaar(Zie foto). \n" + "\n" +
               "Je tankt steeds met korting.\n" +
               "Wat is je besparing aan benzinekosten ten opzichte van de landelijke adviesprijs in het afgelopen jaar?",
              "36,09"
            },
            { "Level3", @"foto20.png",
              "Je vult dit aquarium tot 10 cm onder de rand. \n" +
              "Na een week is 4% van het water verdampt. \n" + "\n" +
               "Hoeveel liter is er verdampt?", 
              "9"
            },
            { "Level3", @"foto21.png",
              "Je bekijkt de resultaten van enkele jaren van de tuinvogeltelling. \n" + "\n" +
               "Van welke vogel staan de gegevens in de staafgrafiek? \n",
              "pimpelmees"
            },
            { "Level3", @"foto22.png",
              "De tabel kan worden uitgebreid naar grotere en kleinere lichaamslengtes en binnenbeenlengtes. \n" +
               "Wat moet de framemaat zijn van een tourfiets voor een meisje dat 1,62 m lang is? \n" +
               "Rond af op hele centimeters.",
              "48"
            },
            { "Level3", @"foto23.png",
              "Je hebt 11 maandelijkse voorschotten betaald van € 64,15. \n" +
               "Hoeveel zal je volgens de eindafrekening nog moeten betalen?",
              "45,34"
            },
            { "Level3", @"foto24.png",
              "De familie Verboom wil de hele achtertuin opknappen. \n" +
              "Ze graven de bovenste 15 cm grond weg.\n" +
              "De familie Verboom wil de hele achtertuin opknappen. \n" +
              "Ze brengen de afgegraven grond naar een container. \n" +
              "Ze huren de containers zo dat ze ze goedkoop mogelijk uit zijn. Wat moeten ze betalen?",
              "760,00"
            },
            { "Level3", @"foto25.png",
              "In een buurthuis mag jij boekenplanken ophangen voor 1000 boeken. \n" +
               "De boeken zijn gemiddeld 2,4 cm dik. Je gebruikt alleen hele planken. \n" +
               "Je gebruikt vier plankendragers per plank. \n" +
               "Elke plankendrager wordt aan de muur vastgezet met drie schroeven en met drie pluggen. \n" +
               "De planken komen los op de dragers te liggen. \n",
              "194,15"
            },
            { "Level3", @"foto26.png",
               "Op een pot pindakaas staat het volgende:(Zie foto) \n" + "\n" +
               "De pindakaas (15 g) op een boterham bevat 96 kcal. \n" +
               "Hoeveel hele boterhammen met pindakaas moet je minimaal eten voor de aanbevolen dagelijkse hoeveelheid vitamine E?",
              "4"
            }
        };
        public MainWindow()
        {
            InitializeComponent();

            btnVolgende.Click += btnVolgende_Click;
            btnlvl1.Click += Btnlvl1_Click;
            btnlvl2.Click += Btnlvl2_Click;
            btnlvl3.Click += Btnlvl3_Click;
        }


        private void Btnlvl1_Click(object sender, RoutedEventArgs e)
        {
            LevelSelec = Level.Level1.ToString();
            ToonOpgave();
            Hidee();
            lblevel.Content = "Level 1";
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string url = path + @"images\" + Opgaves[element, 1];

            imgCover.Source = new BitmapImage(new Uri(url));
            txbOpgaves.Text = Opgaves[element, 2];
           // element += 1;
        }


        private void Btnlvl2_Click(object sender, RoutedEventArgs e)
        {
            LevelSelec = Level.Level2.ToString();
            ToonOpgave();
            Hidee();
            lblevel.Content = "Level 2";


        }

        private void Btnlvl3_Click(object sender, RoutedEventArgs e)
        {
            LevelSelec = Level.Level3.ToString();
            ToonOpgave();
            Hidee();
            lblevel.Content = "Level 3";
        }
        private void Hidee()
        {
            btnlvl1.Visibility = Visibility.Hidden;
            btnlvl2.Visibility = Visibility.Hidden;
            btnlvl3.Visibility = Visibility.Hidden;
            txtnaam.Visibility = Visibility.Hidden;
            lbnaamtxt.Visibility = Visibility.Hidden;
            lblevel.Visibility = Visibility.Visible;
            lbnaam.Visibility = Visibility.Visible;
            lbnaam.Content = txtnaam.Text;
            btnexit.Visibility = Visibility.Visible;
            imgCover.Visibility = Visibility.Visible;
            txbOpgaves.Visibility = Visibility.Visible;
            txbAntwoord.Visibility = Visibility.Visible;
            btnVolgende.Visibility = Visibility.Visible;
            lbGoed.Visibility = Visibility.Visible;
            lbFout.Visibility = Visibility.Visible;
            lblGoedAnt.Visibility = Visibility.Visible;
            lblFoutAnt.Visibility = Visibility.Visible;
            txbNote.Visibility = Visibility.Hidden;
        }

        private void ToonOpgave()
        {

            if (Opgaves[element, 0] != LevelSelec)
            {
                do
                {
                    terug();
                }
                while (Opgaves[element, 0] != LevelSelec);
            }
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string url = path + @"images\" + Opgaves[element, 1];

            imgCover.Source = new BitmapImage(new Uri(url));
            txbOpgaves.Text = Opgaves[element, 2];
        }

        private void terug()
        {
            element += 1;

            if (element == Opgaves.GetLength(0))
            {
                MessageBox.Show("u resultaat zijn \n" + "Fout: " + lblFoutAnt.Content + "\n" + "Goed: " + lblGoedAnt.Content);
                Application.Current.Shutdown();
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            }
        }

        private void btnVolgende_Click(object sender, RoutedEventArgs e)
        {
            string goedeAntwoord = Opgaves[element, 3];

            if (goedeAntwoord == txbAntwoord.Text)
            {
                lblGoedAnt.Content = Int32.Parse(lblGoedAnt.Content.ToString()) + 1;
            }
            else if (string.IsNullOrWhiteSpace(txbAntwoord.Text))
            {
                MessageBox.Show("Een antwoord moet gegeven worden!");
                return;
            }


            else
            {
                lblFoutAnt.Content = Int32.Parse(lblFoutAnt.Content.ToString()) + 1;

            }
            txbAntwoord.Text = "";
            txbAntwoord.Focus();


            terug();
            ToonOpgave();
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Wilt u de toets beeindigen?", "Beeindigen?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);

                Application.Current.Shutdown();
            }
        }
    }
}
