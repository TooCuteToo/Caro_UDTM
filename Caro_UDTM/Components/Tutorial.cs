using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro_UDTM.Components
{
  class Tutorial
  {
    public string tutorialText;
    public Image tutorialImage;

    public Tutorial(string tutorialText, Image tutorialImage)
    {
      this.tutorialImage = tutorialImage;
      this.tutorialText = tutorialText;
    }
  }
}
