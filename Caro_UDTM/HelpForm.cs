using Caro_UDTM.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM
{
  public partial class HelpForm : Form
  {
    int index;
    private Tutorial[] tutorialData;

    public HelpForm()
    {
      InitializeComponent();
      index = 0;

      nextBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
      previousBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;

      nextBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
      previousBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;

      tutorialData = new Tutorial[] {
                new Tutorial("ĐÂY LÀ MỘT TRÒ CHƠI ĐỐI KHÁNG.\nDIỄN RA TRÊN BÀN CỜ 21x21 Ô.\nVỚI 2 QUÂN CỜ LÀ X VÀ O.\nNƯỚC ĐI KHÔNG BỊ GIỚI HẠN.", Properties.Resources.tutorial_1),
                new Tutorial("NGƯỜI CHƠI NÀO CÓ 5 QUÂN LIÊN TIẾP.\nKHÔNG BỊ CHẶN HAI ĐẦU LÀ THẮNG.", Properties.Resources.tutorial_2),
                new Tutorial("TRÒ CHƠI GỒM 3 CHẾ ĐỘ CHƠI:\n\t- CHƠI VỚI MÁY.\n\t- CHƠI VỚI NGƯỜI.\n\t- CHƠI LAN.", Properties.Resources.tutorial_3),
                new Tutorial("KHI ĐÁNH VỚI MÁY SẼ GỒM CÓ 2 LỰA CHỌN:\n\t- NGƯỜI ĐÁNH TRƯỚC.\n\t- MÁY ĐÁNH TRƯỚC.", Properties.Resources.tutorial_4),
                new Tutorial("Ở CHẾ ĐỘ ĐÁNH VỚI MÁY NGƯỜI CHƠI CÓ THỂ CHỌN MỨC ĐỘ KHÓ:\n\t- MÁY DỄ.\n\t- MÁY TRUNG BÌNH.\n\t- MÁY KHÓ.\n LƯU Ý: ĐỘ KHÓ TỈ LỆ VỚI THỜI GIAN TÍNH TOÁN.", Properties.Resources.tutorial_5),
            };

      pictureBox1.Image = tutorialData[index].tutorialImage;
      richTextBox1.Text = tutorialData[index].tutorialText;

      index++;
    }

    private void startGameBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;

      if (index < tutorialData.Count())
      {
        pictureBox1.Image = tutorialData[index].tutorialImage;
        richTextBox1.Text = tutorialData[index].tutorialText;

        index = index + 1 >= tutorialData.Count() ? 0 : index + 1;
        return;
      }

      index = 0;
    }

    private void previousBtn_Click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;

      if (index > -1)
      {
        pictureBox1.Image = tutorialData[index].tutorialImage;
        richTextBox1.Text = tutorialData[index].tutorialText;

        index = index - 1 < 0 ? tutorialData.Count() - 1 : index - 1;
        return;
      }

      index = tutorialData.Count() - 1;
    }
  }
}
