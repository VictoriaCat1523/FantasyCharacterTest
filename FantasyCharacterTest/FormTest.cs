using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyCharacterTest
{
    public partial class FormTest : Form
    {
        int questionIndex = 0;
        int[] answers;
        public FormTest()
        {
            InitializeComponent();
            answers = new int[4];
            UpdateQuestion();
        }
        void UpdateQuestion()
        {
            switch (questionIndex)
            {
                case 0:
                    lblQuestion.Text = "Какое оружие вы предпочитаете использовать в бою?";
                    rbtnAnswer1.Text = "Меч или другое холодное оружие.";
                    rbtnAnswer2.Text = "Лук и стрелы.";
                    rbtnAnswer3.Text = "Волшебные заклинания.";
                    rbtnAnswer4.Text = "Боевая посох или кинжал.";
                    break;
                case 1:
                    lblQuestion.Text = "Что вам ближе по духу?";
                    rbtnAnswer1.Text = "Справедливость и защита слабых.";
                    rbtnAnswer2.Text = "Приключения и исследования неизведанных земель.";
                    rbtnAnswer3.Text = "Знания и магия.";
                    rbtnAnswer4.Text = "Хитрость и скрытность.";
                    break;
                case 2:
                    lblQuestion.Text = "Какое окружение вам нравится больше всего?";
                    rbtnAnswer1.Text = "Густые леса и зеленые поля.";
                    rbtnAnswer2.Text = "Высокие горы и заснеженные вершины.";
                    rbtnAnswer3.Text = "Загадочные подземелья и темные пещеры.";
                    rbtnAnswer4.Text = "Величественные замки и древние руины.";
                    break;
                case 3:
                    lblQuestion.Text = "Какое качество важно для вас в команде?";
                    rbtnAnswer1.Text = "Сильные и преданные друзья.";
                    rbtnAnswer2.Text = "Лидерские навыки и стратегическое мышление.";
                    rbtnAnswer3.Text = "Умные и искусные спутники.";
                    rbtnAnswer4.Text = "Гибкость и возможность работать в одиночку.";
                    break;
                default:
                    // Отображение результата
                    int maxIndex = GetMaxIndex(answers);
                    FormResult result_test = new FormResult();
                    result_test.initResultat(maxIndex);
                    result_test.ShowDialog();
                    Close();
                    break;
            }
        }

        private int GetMaxIndex(int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }
            return maxIndex;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtnAnswer1.Checked || rbtnAnswer2.Checked || rbtnAnswer3.Checked || rbtnAnswer4.Checked)
            {
                questionIndex++;
                if (questionIndex < 3)
                {
                    if (rbtnAnswer1.Checked)
                        answers[0]++;
                    else if (rbtnAnswer2.Checked)
                        answers[1]++;
                    else if (rbtnAnswer3.Checked)
                        answers[2]++;
                    else if (rbtnAnswer4.Checked)
                        answers[3]++;
                }
                else
                    btnNext.Text = "Завершить";

                UpdateQuestion();
                // Сброс выбора радиокнопок
                rbtnAnswer1.Checked = false;
                rbtnAnswer2.Checked = false;
                rbtnAnswer3.Checked = false;
                rbtnAnswer4.Checked = false;
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
            }
        }

    }
}
