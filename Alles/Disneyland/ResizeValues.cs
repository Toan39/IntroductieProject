using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Disneyland
{
    /// <summary>
    /// The partial classes in this cs.file resizes forms, if user wants a different size.
    /// </summary>
    partial class RouteMapInputForm
    {
        private void RouteMapInputForm_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            HomeButton.Width = (int)(60 * scaleX);
            HomeButton.Height = (int)(24 * scaleY);

            PriorityRidesCheckedListBox.Size = new Size((int)(220 * scaleX), (int)(165 * scaleY));
            PriorityRidesCheckedListBox.Location = new Point((int)(10 * scaleX), (int)(75 * scaleY));

            SelectedRidesLabel.Location = new Point((int)(440 * scaleX), (int)(41 * scaleY));
            RidesLabel.Location = new Point((int)(25 * scaleX), (int)(41 * scaleY));

            PriorityRidesListBox.Size = new Size((int)(210 * scaleX), (int)(104 * scaleY));
            PriorityRidesListBox.Location = new Point((int)(385 * scaleX), (int)(75 * scaleY));

            DisneyLandPictureBox.Size = new Size((int)(143 * scaleX), (int)(209 * scaleY));
            DisneyLandPictureBox.Location = new Point((int)(237 * scaleX), (int)(52 * scaleY));

            InformationButton.Size = new Size((int)(242 * scaleX), (int)(76 * scaleY));
            InformationButton.Location = new Point((int)(60 * scaleX), (int)(285 * scaleY));

            GoButton.Size = new Size((int)(231 * scaleX), (int)(76 * scaleY));
            GoButton.Location = new Point((int)(310 * scaleX), (int)(285 * scaleY));

            PriorityRidesCheckedListBox.Font = new Font(PriorityRidesCheckedListBox.Font.FontFamily, (float)(7.8 * scaleY));
            PriorityRidesListBox.Font = new Font(PriorityRidesListBox.Font.FontFamily, (float)(7.8 * scaleY));
            HomeButton.Font = new Font(HomeButton.Font.FontFamily, (float)(7.8 * scaleY));
            RidesLabel.Font = new Font(RidesLabel.Font.FontFamily, (float)(7.8 * scaleY));
            SelectedRidesLabel.Font = new Font(SelectedRidesLabel.Font.FontFamily, (float)(7.8 * scaleY));
            InformationButton.Font = new Font(InformationButton.Font.FontFamily, (float)(7.8 * scaleY));
            GoButton.Font = new Font(GoButton.Font.FontFamily, (float)(7.8 * scaleY));
        }
    }

    partial class RouteMap
    {
        private void RouteMap_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 584);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            HomeButton.Width = (int)(60 * scaleX);
            PrintButton.Location = new Point(HomeButton.Location.X + HomeButton.Width, 2);
            PrintButton.Width = (int)(60 * scaleX);
        }
    }

    partial class MainMenu
    {
        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            RouteButton.Width = (int)(204 * scaleX);
            RouteButton.Height = (int)(82 * scaleY);
            RouteButton.Location = new Point((int)(329 * scaleX), (int)(274 * scaleY));

            DatePickerButton.Width = (int)(204 * scaleX);
            DatePickerButton.Height = (int)(82 * scaleY);
            DatePickerButton.Location = new Point((int)(329 * scaleX), (int)(187 * scaleY));

            DisneyLandPictureBox.Size = new Size((int)(204 * scaleX), (int)(239 * scaleY));
            DisneyLandPictureBox.Location = new Point((int)(51 * scaleX), (int)(128 * scaleY));

            MainTextLabel1.Font = new Font(MainTextLabel1.Font.FontFamily, (float)(28.2 * scaleY));
            MainTextLabel2.Font = new Font(MainTextLabel2.Font.FontFamily, (float)(19.8 * scaleY));

            MainTextLabel1.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel1.Size.Width), (int)(28 * scaleY));
            MainTextLabel2.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel2.Size.Width), (int)(93 * scaleY));
        }
    }

    partial class DatePickerInputForm
    {
        private void DatePickerInputForm_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            HomeButton.Width = (int)(60 * scaleX);
            HomeButton.Height = (int)(24 * scaleY);

            FindDateButton.Width = (int)(350 * scaleX);
            FindDateButton.Height = (int)(45 * scaleY);
            FindDateButton.Location = new Point((int)((0.5 * this.Width) - 0.5 * FindDateButton.Size.Width), (int)(this.Height - 100));

            WeekTextbox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));
            DaysComboBox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));
            ChildrenComboBox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));
            AdultComboBox.Size = new Size((int)(54 * scaleX), (int)(21 * scaleY));

            WeekTextbox.Location = new Point((int)((0.5 * this.Width) - 0.5 * WeekTextbox.Size.Width), (int)(85 * scaleY));
            DaysComboBox.Location = new Point((int)((0.5 * this.Width) - 0.5 * DaysComboBox.Size.Width), (int)(155 * scaleY));
            ChildrenComboBox.Location = new Point((int)((0.5 * this.Width) - 0.5 * ChildrenComboBox.Size.Width), (int)(225 * scaleY));
            AdultComboBox.Location = new Point((int)((0.5 * this.Width) - 0.5 * AdultComboBox.Size.Width), (int)(295 * scaleY));

            AdultLabel.Font = new Font(AdultLabel.Font.FontFamily, (float)(19.8 * scaleY));
            WeekLabel.Font = new Font(WeekLabel.Font.FontFamily, (float)(19.8 * scaleY));
            ChildrenLabel.Font = new Font(ChildrenLabel.Font.FontFamily, (float)(19.8 * scaleY));
            DaysLabel.Font = new Font(DaysLabel.Font.FontFamily, (float)(19.8 * scaleY));
            MainTextLabel.Font = new Font(MainTextLabel.Font.FontFamily, (float)(28.2 * scaleY));

            MainTextLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel.Size.Width), (int)(1 * scaleY));
            WeekLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * WeekLabel.Size.Width), (int)(50 * scaleY));
            DaysLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * DaysLabel.Size.Width), (int)(120 * scaleY));
            ChildrenLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * ChildrenLabel.Size.Width), (int)(190 * scaleY));
            AdultLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * AdultLabel.Size.Width), (int)(260 * scaleY));
        }
    }

    partial class DatePickerForm
    {
        private void DatePickerForm_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(616, 405);
            double scaleX = (double)this.Width / (double)this.MinimumSize.Width;
            double scaleY = (double)this.Height / (double)this.MinimumSize.Height;

            HomeButton.Width = (int)(60 * scaleX);
            HomeButton.Height = (int)(24 * scaleY);

            CalendarButton.Width = (int)(616 * scaleX);
            CalendarButton.Height = (int)(45 * scaleY);
            CalendarButton.Location = new Point((int)((0.5 * this.Width) - 0.5 * CalendarButton.Size.Width), (int)(this.Height - 100));

            MainTextLabel.Font = new Font(MainTextLabel.Font.FontFamily, (float)(28.2 * scaleY));
            ResultLabel.Font = new Font(ResultLabel.Font.FontFamily, (float)(19.8 * scaleY));
            mmRainLabel.Font = new Font(mmRainLabel.Font.FontFamily, (float)(19.8 * scaleY));
            CrowdLabel.Font = new Font(CrowdLabel.Font.FontFamily, (float)(19.8 * scaleY));
            CostLabel.Font = new Font(CostLabel.Font.FontFamily, (float)(19.8 * scaleY));
            pictureBox1.Size = new Size((int)(104 * scaleX), (int)(80 * scaleY));
            Crowdlevelpanel.Size = new Size((int)(260 * scaleX), (int)(40 * scaleY));

            MainTextLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * MainTextLabel.Size.Width), (int)(1 * scaleY));
            ResultLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * ResultLabel.Size.Width), (int)(70 * scaleY));
            mmRainLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * mmRainLabel.Size.Width), (int)(120 * scaleY));
            CrowdLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * CrowdLabel.Size.Width), (int)(180 * scaleY));
            CostLabel.Location = new Point((int)((0.5 * this.Width) - 0.5 * CostLabel.Size.Width), (int)(270 * scaleY));
            Crowdlevelpanel.Location = new Point((int)((0.5 * this.Width) - 0.5 * Crowdlevelpanel.Size.Width), (int)(219 * scaleY));
            pictureBox1.Location = new Point((int)(150 * scaleX), (int)(105 * scaleY));
            Crowdlevelpanel.Invalidate();
        }
    }
}
