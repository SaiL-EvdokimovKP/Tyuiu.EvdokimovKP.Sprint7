using Project.V13.Lib;
using System.Media;
using System;
using System.Windows.Forms;
using WMPLib;

namespace Project.V13.Main
{
    public partial class FormMain : Form
    {
        private WindowsMediaPlayer wmp;

        //Массив для флагов
        private string[] flagPaths = new string[] {
            @"C:\Users\evdok\Desktop\Флаги\Флаг Китая в 1921 году.jpg",
            @"C:\Users\evdok\Desktop\Флаги\загруженное.jpg",
            @"C:\Users\evdok\Desktop\Флаги\загруженное (1).jpg",
            @"C:\Users\evdok\Desktop\Флаги\indonesia flag (i doubt it, this could be monaco flag).jpg",
            @"C:\Users\evdok\Desktop\Флаги\پاكِستان.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Флаг страны Нигерия.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Brazil Fighters.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Народная республика Б.jpg",
            @"C:\Users\evdok\Desktop\Флаги\texturized Russian Flag of Russia.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Флаг страны Мексика.jpg",
            @"C:\Users\evdok\Desktop\Флаги\12 500+ стокових фото, фото роялті-фрі та зображень на тему Japanese Flag - iStock.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Ethiopia flag.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Philippines Large Flag.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Bandera de Egipto - Wikipedia, la enciclopedia libre.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Flag of Vietnam.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Democratic Republic of the Congo.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Irán - Wikipedia, la enciclopedia libre.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Turkey.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Alemania en la Copa Mundial de Fútbol de 2014 - Wikipedia, la enciclopedia libre.jpg",
            @"C:\Users\evdok\Desktop\Флаги\Флаг страны Таиланд.jpg"
        };

        // Массив площадей стран
        private int[] s = new int[] {
            9640011, 3287263, 9372610, 1904569, 881913,
            923768, 8515767, 147570, 17125191, 1964375,
            377975, 1104300, 300000, 1002450, 331212,
            2344858, 1648195, 783356, 357022, 513120
        };

        // Массив столиц
        private string[] stalica = new string[] {
            "Пекин", "Нью-Дели", "Вашингтон", "Джакарта", "Исламабад",
            "Абуджа", "Бразилиа", "Дакка", "Москва", "Мехико",
            "Токио", "Аддис-Абеба", "Манила", "Каир", "Ханой",
            "Киншаса", "Тегеран", "Анкара", "Берлин", "Бангкок"
        };

        // Массив населения стран
        private int[] population = new int[] {
            1412000000, 1380000000, 335000000, 277000000, 238000000,
            227000000, 217000000, 173000000, 147000000, 128000000,
            126000000, 114000000, 102000000, 102000000, 89000000,
            85000000, 82000000, 76000000, 68000000, 67000000
        };

        // Массив названий стран
        private string[] countries = new string[] {
            "Китай", "Индия", "США", "Индонезия", "Пакистан",
            "Нигерия", "Бразилия", "Бангладеш", "Россия", "Мексика",
            "Япония", "Эфиопия", "Филиппины", "Египет", "Вьетнам",
            "ДР Конго", "Иран", "Турция", "Германия", "Таиланд"
        };

        //  Музыка
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        bool isPlaying = false;
        bool button = false;
        public FormMain()
        {
            InitializeComponent();
            music.URL = @"C:\Users\evdok\Desktop\музака для спринта\ABBA_-_Happy_New_Year_47835607.mp3";
            music.settings.volume = 47;
            music.controls.play();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["InfoButton"].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                OpenCountryFormByIndex(index);
            }
        }

        // Методы для открытия форм для каждой страны
        private void OpenFormForChina()
        {
            FormChina form = new FormChina();
            form.Show();
        }

        private void OpenFormForIndia()
        {
            FormIndia form = new FormIndia();
            form.Show();
        }

        private void OpenFormForUSA()
        {
            FormUSA form = new FormUSA();
            form.Show();
        }

        private void OpenFormForIndonesia()
        {
            FormIndonesia form = new FormIndonesia();
            form.Show();
        }

        private void OpenFormForPakistan()
        {
            FormPakistan form = new FormPakistan();
            form.Show();
        }

        private void OpenFormForNigeria()
        {
            FormNigeria form = new FormNigeria();
            form.Show();
        }

        private void OpenFormForBrazil()
        {
            FormBrazil form = new FormBrazil();
            form.Show();
        }

        private void OpenFormForBangladesh()
        {
            FormBangladesh form = new FormBangladesh();
            form.Show();
        }

        private void OpenFormForRussia()
        {
            FormRussia form = new FormRussia();
            form.Show();
        }

        private void OpenFormForMexico()
        {
            FormMexico form = new FormMexico();
            form.Show();
        }

        private void OpenFormForJapan()
        {
            FormJapan form = new FormJapan();
            form.Show();
        }

        private void OpenFormForEthiopia()
        {
            FormEthiopia form = new FormEthiopia();
            form.Show();
        }

        private void OpenFormForPhilippines()
        {
            FormPhilippines form = new FormPhilippines();
            form.Show();
        }

        private void OpenFormForEgypt()
        {
            FormEgypt form = new FormEgypt();
            form.Show();
        }

        private void OpenFormForVietnam()
        {
            FormVietnam form = new FormVietnam();
            form.Show();
        }

        private void OpenFormForCongo()
        {
            FormCongo form = new FormCongo();
            form.Show();
        }

        private void OpenFormForIran()
        {
            FormIran form = new FormIran();
            form.Show();
        }

        private void OpenFormForTurkey()
        {
            FormTurkey form = new FormTurkey();
            form.Show();
        }

        private void OpenFormForGermany()
        {
            FormGermany form = new FormGermany();
            form.Show();
        }

        private void OpenFormForThailand()
        {
            FormThailand form = new FormThailand();
            form.Show();
        }

        private void OpenCountryFormByIndex(int index)
        {
            switch (index)
            {
                case 0: OpenFormForChina(); break;
                case 1: OpenFormForIndia(); break;
                case 2: OpenFormForUSA(); break;
                case 3: OpenFormForIndonesia(); break;
                case 4: OpenFormForPakistan(); break;
                case 5: OpenFormForNigeria(); break;
                case 6: OpenFormForBrazil(); break;
                case 7: OpenFormForBangladesh(); break;
                case 8: OpenFormForRussia(); break;
                case 9: OpenFormForMexico(); break;
                case 10: OpenFormForJapan(); break;
                case 11: OpenFormForEthiopia(); break;
                case 12: OpenFormForPhilippines(); break;
                case 13: OpenFormForEgypt(); break;
                case 14: OpenFormForVietnam(); break;
                case 15: OpenFormForCongo(); break;
                case 16: OpenFormForIran(); break;
                case 17: OpenFormForTurkey(); break;
                case 18: OpenFormForGermany(); break;
                case 19: OpenFormForThailand(); break;
            }
        }

        private void buttonRes_EKP_Click(object sender, EventArgs e)
        {
            // Очищаем и настраиваем DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.RowTemplate.Height = 60; // Высота 80 пикселей

            // Добавляем колонки
            dataGridView1.Columns.Add("Country", "Страна");
            dataGridView1.Columns.Add("Population", "Население");
            dataGridView1.Columns.Add("Stalica", "Столица");
            dataGridView1.Columns.Add("S", "Площадь");

            // Флаги
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Flag";
            imageColumn.HeaderText = "Флаг";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Масштабирование
            imageColumn.Width = 100; // Ширина колонки с картинками
            dataGridView1.Columns.Add(imageColumn);

            // Колонка с кнопками "Информация"
            DataGridViewButtonColumn infoButtonColumn = new DataGridViewButtonColumn();
            infoButtonColumn.Name = "InfoButton";
            infoButtonColumn.HeaderText = "Действия";
            infoButtonColumn.Text = "Информация";
            infoButtonColumn.UseColumnTextForButtonValue = true; // Все кнопки будут с текстом "Информация"
            infoButtonColumn.Width = 110;
            dataGridView1.Columns.Add(infoButtonColumn);

            // Вывод данных
            for (int i = 0; i < population.Length; i++)
            {
                string formattedPopulation = Convert.ToString(population[i]);
                string plohad = Convert.ToString(s[i]) + " км²";
                int rowIndex = dataGridView1.Rows.Add(countries[i], formattedPopulation, stalica[i], plohad);

                // Добавляем картинку
                if (i < flagPaths.Length && File.Exists(flagPaths[i]))
                {
                    Image flagImage = Image.FromFile(flagPaths[i]);
                    dataGridView1.Rows[rowIndex].Cells["Flag"].Value = flagImage;
                }
            }
            dataGridView1.ReadOnly = true; //только для чтения
            dataGridView1.AllowUserToAddRows = false; // Запретить добавление новых строк
            dataGridView1.AllowUserToDeleteRows = false; // Запретить удаление строк
            dataGridView1.AllowUserToOrderColumns = false; // Запретить перетаскивание колонок
            dataGridView1.AllowUserToResizeRows = false; // Запрет изменения высоты колонки
            dataGridView1.AllowUserToResizeColumns = false; // Запрет изменения ширины колонок
        }



        private void button3_Click(object sender, EventArgs e) //население
        {
            Population formpopulation = new Population();

            // Открываем вторую форму
            formpopulation.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //информация
        {
            FormInfo formInfo = new FormInfo();

            // Открываем вторую форму
            formInfo.ShowDialog();
        }

        private void buttonS_EKP_Click(object sender, EventArgs e)
        {
            FormS formS = new FormS();
            formS.ShowDialog();
        }

        private void buttonDs_EKP_Click(object sender, EventArgs e)
        {
            Analitic analitic = new Analitic();
            analitic.ShowDialog();
        }

        private void buttonS_Analitic_EKP_Click(object sender, EventArgs e)
        {
            AnaliticS analiticS = new AnaliticS();
            analiticS.ShowDialog();
        }

        private void textBoxDano_EKP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
