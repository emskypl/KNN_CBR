using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //

namespace KNN
{

    public partial class Form : System.Windows.Forms.Form
    {

        double sepalLength = 0; double sepalWidth = 0;
        double petalLength = 0; double petalWidth = 0;
        int vectorCount = 1;
        int irisSetosaCount = 0;
        int irisVersicolorCount = 0;
        int irisVirginicaCount = 0;
        public double odleglosc;
        public int zmWektorowReferencyjnych;
        List<ClassificatorType> listOfClassificators = new List<ClassificatorType>();
        ToolTip instructionsRegular = new ToolTip();
        ToolTip instructionsMouseEvents = new ToolTip();

        bool instructionsOn = false;

        public Form()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;

            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Program uruchmiony. \n";
            loadDatabase();
            
            instructionsRegular.AutoPopDelay = 5000;
            instructionsRegular.InitialDelay = 500;
            instructionsRegular.ReshowDelay = 500;
            instructionsRegular.ShowAlways = true;
            instructionsRegular.ToolTipTitle = "Instrukcja:";
            instructionsRegular.IsBalloon = true;

            instructionsMouseEvents.AutoPopDelay = 5000;
            instructionsMouseEvents.InitialDelay = 500;
            instructionsMouseEvents.ReshowDelay = 500;
            instructionsMouseEvents.ShowAlways = true;
            instructionsMouseEvents.ToolTipTitle = "Instrukcja:";
            instructionsMouseEvents.IsBalloon = false;

            MessageBox.Show("Witaj w \u0022KNN - Diagnoza Kwiatu Irysa\u0022! \n" +
                            "Użyj przycisku \u0022Pokaż Instrukcję\u0022 aby uzyskać pomoc.");

        }
        BazaDanychStruktura bazaDanychStruktura = new BazaDanychStruktura();


        private void saveButton_Click(object sender, EventArgs e)
        {
            
            using (var dataContext = new BazaDanychStruktura())
            {
                ControlTextBox();

                if (!textBoxClassification.Text.Equals(""))
                {
                    dataContext.Irises.Add(new Irises() { sepal_length = Double.Parse(textBoxSepalLength.Text.ToString()), sepal_width = Double.Parse(textBoxSepalWidth.Text.ToString()), petal_length = Double.Parse(textBoxPetalLength.Text.ToString()), petal_width = Double.Parse(textBoxPetalWidth.Text.ToString()), classification = textBoxClassification.Text.ToString() });
                    dataContext.SaveChanges();
                    logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Dodano wpis do bazy danych. \n";
                }
                else
                {
                    logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Nie określono klasyfikatora. \n";
                }
            }
           
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void loadDatabase()
        {
            var DaneWczytane = from BazaDanychStruktura in bazaDanychStruktura.Irises select BazaDanychStruktura;           
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns.Add("ID", "ID");
            //TODO: pierwsza kolumna width
            //this.dataGridView1.Columns[0].Width = 250;
            dataGridView.Columns.Add("sepal_length", "Długość działki kielicha");
            dataGridView.Columns.Add("sepal_width", "Szerokość działki kielicha");
            dataGridView.Columns.Add("petal_length", "Długość płatka");
            dataGridView.Columns.Add("petal_width", "Szerokość płatka");
            dataGridView.Columns.Add("classification", "Klasyfikacja");
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.Columns[0].Width = 45;
            this.dataGridView.Columns[1].Width = 160;
            this.dataGridView.Columns[2].Width = 160;
            this.dataGridView.Columns[5].Width = 100;
            foreach (var kursor in DaneWczytane)
            {
                dataGridView.Rows.Add(kursor.ID, kursor.sepal_length, kursor.sepal_width, kursor.petal_length, kursor.petal_width, kursor.classification);
            }
            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Wczytano bazę danych. \n";         
            
        }
        //TODO:
        //
        //
        private void modifyButton_Click(object sender, EventArgs e)
        {
            
            if (!textBoxID.Text.Equals(""))
            {
                int IDtab = Int32.Parse(textBoxID.Text.ToString());
            
            Irises dane = new Irises()
            {
                ID = IDtab,
                sepal_length = sepalLength,
                sepal_width = sepalWidth,
                petal_length = petalLength,
                petal_width = petalWidth,
                classification = textBoxClassification.Text.ToString()
               
            };
            try { 
            if (!textBoxClassification.Text.Equals(""))
           {
                using (var dataContext = new BazaDanychStruktura())
                {
                            /*
                            var x = dataContext.Irises.First<Irises>();
                            var y = dataContext.Irises.ElementAt<Irises>(2);

                            y.ID = IDtab;
                            y.petal_length = petalLength;
                            y.petal_width = petalWidth;
                            y.sepal_length = sepalLength;
                            y.sepal_width = sepalWidth;
                            
                            x.sepal_length = sepalLength;
                            x.sepal_width = sepalWidth;
                            x.petal_length = petalLength;
                            x.petal_width = petalWidth;
                            x.classification = textBoxClassification.Text.ToString();
                            */
                            dataContext.Entry(dane).State = EntityState.Modified;
                            dataContext.SaveChanges();
                }
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Zmodyfikowano w bazie wpis o ID " + textBoxID.Text.ToString() + ". \n";
                
            }
            else
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "BŁĄD: Przed modyfikacja, zdiagnozuj." + ". \n";
            }
            }
            catch (Exception) { MessageBox.Show("BŁĄD: Nie ma takiego rekordu."); }
            }
            else
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "BŁĄD: Uprasza się uprzejmię o wpisanie Identyfikatora Irisa. \n";
            }
        }

        private void ControlTextBox()
        {
            if (textBoxSepalLength.Text == "")
            {
                textBoxSepalLength.Text = "0";
            }

            if (textBoxSepalWidth.Text == "")
            {
                textBoxSepalWidth.Text = "0";
            }

            if (textBoxPetalLength.Text == "")
            {
                textBoxPetalLength.Text = "0";
            }

            if (textBoxPetalWidth.Text == "")
            {
                textBoxPetalWidth.Text = "0";
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int IDtab;
            Int32.TryParse(textBoxID.Text.ToString(),out IDtab);
            Irises dane = new Irises()
            {
                ID = IDtab
            };
            if (!IDtab.Equals(0))
            {
                try
                {

                    using (var dataContext = new BazaDanychStruktura())
                    {

                        dataContext.Entry(dane).State = EntityState.Deleted;
                        
                        dataContext.SaveChanges();

                    }
                    logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Usunięto z bazy wpis o ID " + textBoxID.Text.ToString() + ". \n";

                }
                catch (Exception) { logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "BŁĄD: Identyfikator " + IDtab.ToString() + " nie istnieje w bazie \n"; }
            }
            else
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "BŁĄD: Podaj identyfikator.  \n";
            }

        }

        private void diagnozeButton_Click(object sender, EventArgs e)
        {
            KNN();            
        }

        // liczba wektorow referencyjnych

        private void KNN()
        {
            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Uruchomiono diagnozę. \n";
            logBox.Text +=  DateTime.Now.ToString("HH:mm:ss ") + "Zerowanie licznków i listy. \n";
            irisSetosaCount = 0;
            irisVersicolorCount = 0;
            irisVirginicaCount = 0;
            textBoxClassification.Text = "";
            listOfClassificators.Clear();
            logBox.Text +=  DateTime.Now.ToString("HH:mm:ss ") + "Wczytywanie danych z bazy. \n";
            var DaneWczytane = from BazaDanychStruktura in bazaDanychStruktura.Irises select BazaDanychStruktura;
            ControlTextBox();
            logBox.Text +=  DateTime.Now.ToString("HH:mm:ss ") + "Liczenie odległości od wektorów z bazy. \n";
            foreach (var kursor in DaneWczytane)
            {
                odleglosc = Math.Sqrt(Math.Pow(kursor.sepal_length - sepalLength, 2) +
                                      Math.Pow(kursor.sepal_width - sepalWidth, 2) +
                                      Math.Pow(kursor.petal_length - petalLength, 2) +
                                      Math.Pow(kursor.petal_width - petalWidth, 2));
                listOfClassificators.Add(new ClassificatorType() { distance = odleglosc, classificator = kursor.classification });
            }


            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Sortowanie listy odległości. \n";
            listOfClassificators.Sort(delegate (ClassificatorType a, ClassificatorType b)
            {
                return a.distance.CompareTo(b.distance);
            });
            
            foreach (var zm in listOfClassificators)
            {
                Console.WriteLine(zm.distance + "  " + zm.classificator);
            }
 


            FindTheMostFrequentClassificator();
            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Liczenie K = " + vectorCount.ToString() + " najbliższych sąsiadów. \n";
            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Wśród sąsiadów znaleziono " + irisSetosaCount.ToString()+ " × IrisSetosa \n";
            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Wśród sąsiadów znaleziono " + irisVersicolorCount.ToString()+ " × IrisVersicolor \n";
            logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Wśród sąsiadów znaleziono " + irisVirginicaCount.ToString()+ " × IrisVirginica \n";

        }



        public void FindTheMostFrequentClassificator()
        {

            for (int i = 0; i < vectorCount; i++)
            {
                if (listOfClassificators[i].classificator.Equals("Iris-setosa"))
                {
                    irisSetosaCount++;
                }
                else if (listOfClassificators[i].classificator.Equals("Iris-versicolor"))
                {
                    irisVersicolorCount++;
                }
                else if (listOfClassificators[i].classificator.Equals("Iris-virginica"))
                {
                    irisVirginicaCount++;
                }
            }

            if (irisSetosaCount >= irisVersicolorCount && irisSetosaCount >= irisVirginicaCount)
            {
                if (irisSetosaCount == irisVersicolorCount || irisSetosaCount == irisVirginicaCount)
                {
                    irisSetosaCount = 0;
                    irisVersicolorCount = 0;
                    irisVirginicaCount = 0;
                    vectorCount++;
                    FindTheMostFrequentClassificator();
                }
                else
                {
                    textBoxClassification.Text = "Iris-setosa";
                    logBox.Text +=  DateTime.Now.ToString("HH:mm:ss ") + "Zklasyfikowano jako Iris-setosa \n";
                }
            }
            else if (irisVersicolorCount >= irisSetosaCount && irisVersicolorCount >= irisVirginicaCount)
            {
                if (irisVersicolorCount == irisSetosaCount || irisVersicolorCount == irisVirginicaCount)
                {
                    irisSetosaCount = 0;
                    irisVersicolorCount = 0;
                    irisVirginicaCount = 0;
                    vectorCount++;
                    FindTheMostFrequentClassificator();
                }
                else
                {
                    textBoxClassification.Text = "Iris-versicolor";
                    logBox.Text +=  DateTime.Now.ToString("HH:mm:ss ") + "Zklasyfikowano jako Iris-versicolor \n";
                }
            }
            else
            {
                if (irisVirginicaCount == irisVersicolorCount || irisVirginicaCount == irisSetosaCount)
                {
                    vectorCount++;
                    FindTheMostFrequentClassificator();
                }
                else
                {
                    textBoxClassification.Text = "Iris-virginica";
                    logBox.Text +=  DateTime.Now.ToString("HH:mm:ss ") + "Zklasyfikowano jako Iris-virginica \n";
                }
            }
        }

        public void ControlInsertingToText(TextBox textBox)
        {
            string result = "";
            char[] validChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' };
            if (textBox.Text.Substring(0).Equals(',') || textBox.Text.Substring(0).Equals('.'))
            {
                textBox.Text = "0,";

            }
            else
            {
                foreach (char c in textBox.Text)
                {

                    if (result.Length > 1)
                    {
                        if (result.Substring(result.Length - 1).Equals(".") || result.Substring(result.Length - 1).Equals(","))
                        {
                            validChars[11] = '7';
                            validChars[10] = '8';
                        }
                    }


                    if (Array.IndexOf(validChars, c) != -1)
                    {
                        result += c;

                    }
                    else
                    {
                        result = "";
                    }
                }
            }
            textBox.Text = result;
        }


        private void textBoxSepalLength_TextChanged(object sender, EventArgs e)
        {
            ControlInsertingToText(textBoxSepalLength);
            sepalLength = ParseAndReplace(sepalLength, textBoxSepalLength);
            if (sepalLength > 10)
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Za duża wartość. \n";
                MessageBox.Show("Maksymalna wartość to 10.");
                textBoxSepalLength.Text = "10";
                sepalLength = 10;
               
            }
            textBoxClassification.Text = "";
        }
        private void textBoxSepalWidth_TextChanged(object sender, EventArgs e)
        {
            ControlInsertingToText(textBoxSepalWidth);
            sepalWidth = ParseAndReplace(sepalWidth, textBoxSepalWidth);
            if (sepalWidth > 10)
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Za duża wartość. \n";
                MessageBox.Show("Maksymalna wartość to 10.");
                textBoxSepalWidth.Text = "10";
                sepalWidth = 10;
            }
            textBoxClassification.Text = "";
        }

        private void textBoxPetalLength_TextChanged(object sender, EventArgs e)
        {
            ControlInsertingToText(textBoxPetalLength);
            petalLength = petalLength = ParseAndReplace(petalLength, textBoxPetalLength);
            if (petalLength > 10)
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Za duża wartość. \n";
                MessageBox.Show("Maksymalna wartość to 10.");
                textBoxPetalLength.Text = "10";
                petalLength = 10;
            }
            textBoxClassification.Text = "";
        }

        private void textBoxPetalWidth_TextChanged(object sender, EventArgs e)
        {
            ControlInsertingToText(textBoxPetalWidth);
            petalWidth = ParseAndReplace(petalWidth, textBoxPetalWidth);
            if (petalWidth> 10)
            {
                logBox.Text += DateTime.Now.ToString("HH:mm:ss ") + "Za duża wartość. \n";
                MessageBox.Show("Maksymalna wartość to 10.");
                textBoxPetalWidth.Text = "10";
                petalWidth = 10;
            }
            textBoxClassification.Text = "";
        }        

        private void textBoxVectorNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vectorCount = int.Parse(textBoxVectorNumber.Text.ToString());
                if(vectorCount > 15 || vectorCount < 1)
                {
                    MessageBox.Show("Liczba wektorów referencyjncyh musi się miescić w zakresie od 1 do 15.");
                    vectorCount = 1;
                    textBoxVectorNumber.Text = "1";
                }
            }
            catch (Exception)
            {
                if (!textBoxVectorNumber.Text.Equals(""))
                {
                    textBoxVectorNumber.Text = "";
                }
            }
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            logBox.Text = "";
        }

        private void buttonShowLog_Click(object sender, EventArgs e)
        {
            if (logBox.Visible.Equals(true))
            {
                logBox.Visible = false;
                buttonClearLog.Visible = false;
                logButton.Text = "Pokaż log";
                Form.ActiveForm.Width = 845;
            }
            else
            {
                logBox.Visible = true;
                buttonClearLog.Visible = true;
                logButton.Text = "Ukryj log";
                Form.ActiveForm.Width = 1280;
            }
        }

        public double ParseAndReplace(double value, TextBox textBox)
        {
            string replaceString;
            replaceString = textBox.Text;
            replaceString = replaceString.Replace(",",".");
            if (!replaceString.Equals(""))
            {
                if (replaceString.Substring(0, 1).Equals("."))
                {
                    replaceString = "0"+ replaceString;
                }

            value = Double.Parse(replaceString,NumberStyles.Float,CultureInfo.InvariantCulture);
            }
            return value;
        }

        private void buttonListOfDistances_Click(object sender, EventArgs e)
        {
            string toMessageBox = "";
            if (!textBoxClassification.Text.Equals(""))
            {

                for (int i = 0; i < vectorCount; i++)
                    toMessageBox += listOfClassificators[i].distance + " - " + listOfClassificators[i].classificator + "\n";
                MessageBox.Show(toMessageBox);

            }

            
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }

        private void buttonInstructions_Click(object sender, EventArgs e)
        {
            //instrukcje.SetToolTip(this.ELEMENT, TEKST);

            if (instructionsOn == false)
            {
                instructionsButton.Text = "Ukryj Instrukcje";

                //grupy
                instructionsRegular.SetToolTip(this.groupBoxID, "To jest sekcja wykorzystywana do operacji na bazie z użyciem pola ID.");
                instructionsRegular.SetToolTip(this.groupBoxSepal, "To jest sekcja wykorzystywana do wpisywania elementów wektora związanych z działką kielicha kwiatu irysa, poniższe dane porównywane będą z istniejącymi w bazie wpisami.");
                instructionsRegular.SetToolTip(this.groupBoxPetal, "To jest sekcja wykorzystywana do wpisywania elementów wektora związanych z płatkiem kwiatu irysa, poniższe dane porównywane będą z istniejącymi w bazie wpisami.");
                instructionsRegular.SetToolTip(this.groupBoxDiagnoze, "To jest sekcja wykorzystywana do wyboru liczby wektorów referencyjnych oraz dokonania diagnozy przypadku o podanych specyfikacjach, \n " +
                                                                        "program porówna jego podobieństwo do K wpisów istniejących w bazie danych i na tej podstawie odpowiednio sklasyfikuje.");

                //buttony
                instructionsRegular.SetToolTip(this.modifyButton, "Użyj tego przycisku aby podmienić dane wpisu z bazy o wybranym ID danymi, które są wynikiem własnego wpisu oraz wykonanej diagnozy. \n" +
                                                                   "UWAGA: Przed modyfikacją należy wpisać ID istniejącego w bazie wpisu oraz dokonać diagnozy podanych danych!");
                instructionsRegular.SetToolTip(this.deleteButton, "Użyj tego przycisku aby usunąć dane wpisu z bazy o wybranym ID. \n" +
                                                                    "UWAGA: Przed usunięciem należy wpisać ID istniejącego w bazie wpisu!");
                instructionsRegular.SetToolTip(this.reloadButton, "Użyj tego przycisku aby uzupełnić bazę o zmienione już a nadal nieistniejace wpisy.");
                instructionsRegular.SetToolTip(this.saveButton, "Użyj tego przycisku aby zapisać komplet danych, składający się z nowego ID, wpisanych danych działki oraz płatka kwiatu jak i otrzymanej w wyniku diagnozy klasyfikacji. \n" +
                                                        "UWAGA: Przed dodaniem wpisu należy dokonać diagnozy podanych danych!" );
                instructionsRegular.SetToolTip(this.diagnozeButton, "Użyj tego przycisku aby uzyskać klasyfikację dla wpisanego w rubryki przypadku kwiata irysa. \n" +
                                                            "Dokładność klasyfikacji zależna jest od podanej liczby wektorów referencyjnych.");
                instructionsRegular.SetToolTip(this.listButton, "Użyj tego przycisku aby wyświetlić listę określającą podobnieństwo przykładu do istniejących w bazie wpisów.");
                instructionsRegular.SetToolTip(this.instructionsButton, "Użyj tego przycisku aby włączyć lub wyłączyć wyświetlanie dymków instrukcji.");
                instructionsRegular.SetToolTip(this.logButton, "Użyj tego przycisku aby wyświetlić lub ukryć pole ukazujące aktualnie wykonywane w programie operacje.");
                instructionsRegular.SetToolTip(this.buttonClearLog, "Użyj tego przycisku aby usunąć wszelkie informacje obecnie wyświtlane w logu.");

                instructionsOn = true;
            }

            else if (instructionsOn == true)
            {
                instructionsButton.Text = "Pokaż Instrukcje";

                instructionsRegular.RemoveAll();
                instructionsOn = false;
            }
        }

        private void textBoxID_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole określające ID wpisu który zamierzamy zmodyfikować bądź usunąć.", textBoxID, 135, 15);
                
            }
        }

        private void textBoxID_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxID);
            
        }

        private void textBoxSepalLength_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole okreslające długość działki kielicha kwiatu który chcemy porównać do przypadków zanotowanych w bazie danych.", textBoxSepalLength, 135, 15);
                
            }
        }

        private void textBoxSepalLength_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxSepalLength);
            
        }

        private void textBoxSepalWidth_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole okreslające szerokość działki kielicha kwiatu który chcemy porównać do przypadków zanotowanych w bazie danych.", textBoxSepalWidth, 135, 15);
                
            }
        }

        private void textBoxSepalWidth_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxSepalWidth);
            
        }

        private void textBoxPetalLength_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole okreslające długość płatka kwiatu który chcemy porównać do przypadków zanotowanych w bazie danych.", textBoxPetalLength, 135, 15);
                
            }
        }

        private void textBoxPetalLength_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxPetalLength);
            
        }

        private void textBoxPetalWidth_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole okreslające szerokość płatka kwiatu który chcemy porównać do przypadków zanotowanych w bazie danych.", textBoxPetalWidth, 135, 15);
                
            }
        }

        private void textBoxPetalWidth_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxPetalWidth);
            
        }

        private void textBoxVectorNumber_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole określające liczbę wektorów referencyjnych, do których porównywany będzie nasz wpis.", textBoxVectorNumber, 135, 15);
                
            }
        }

        private void textBoxVectorNumber_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxVectorNumber);
            
        }

        private void textBoxClassification_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole określające klasyfikację naszego przypadku określoną na podstawie porównania go do K referencyjnych wektorów z bazy danych.", textBoxClassification, 135, 15);
                
            }
        }

        private void textBoxClassification_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(textBoxClassification);
            
        }

        private void dataGridView_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole wyświetlające wszystkie aktualne wpisy w bazie danych irysów. \n" +
                                  "Na podstawie tych właśnie przypadków określana będzie klasyfikacja własnoręcznie wpisywanych przykładów kwiata.", dataGridView, 0, 0);
                
            }
        }

        private void dataGridView_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(dataGridView);           
        }

        private void logBox_MouseHover(object sender, EventArgs e)
        {
            if (instructionsOn == true)
            {
                instructionsMouseEvents.Show("To jest pole wyświetlające wszystkie aktualnie wykonywane w programie operacje.", logBox, 200, -20);
            }
        }

        private void logBox_MouseLeave(object sender, EventArgs e)
        {
            instructionsMouseEvents.Hide(logBox);
        }
    }
}
