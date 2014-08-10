/*
 * Program: Microchip PWM Calculator
 * Author: Michael D. Stone (AKA Neoaikon)
 * Date: 8/10/2014
 * Copyright (C) 2014 Mid-Ohio Area Robotics
 * 
 * Description: Calculates the number of timer counts
 * required to meet a specific PWM frequency. Counts
 * per Period is how many timer counts occur for the
 * entire duration of the PWM signal. Counts per
 * Division is how many timer counts occur for each
 * step in the PWM signal (0 - Divisons). Since you
 * cannot have fractional counts, this number is rounded
 * up. Error % is how far off the actual PWM frequency will
 * be from the desired PWM frequency.
 * 
 * GPL V3 License
 * --------------
 * This file is part of Microchip PWM Calculator.
 * Foobar is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * Microchip PWM Calculator is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Microchip PWM Calculator.  If not, see <http://www.gnu.org/licenses/>.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicrochipPWMCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the (assumed) floating point values
                float Freq = float.Parse(txtFreq.Text);
                float PWMFreq = float.Parse(txtPWMFreq.Text);
                float Divisions = float.Parse(txtDivs.Text);

                // Counts Per Period = (1/PWMFreq)/(1/(FOSC/4)), where PWMFreq is your PWM Frequency
                // and FOSC is your MCU Clock frequency
                float CountsP = (1.0f / PWMFreq) / (1 / (Freq / 4));

                // Counts Per Divison = (CountsPerPeriod/Divisions).
                float CountsD = CountsP / Divisions;
                
                // If we get any invalid values, change the result text boxes red
                if(CountsD < 1.0f) txtCountsD.BackColor = Color.LightPink;
                else txtCountsD.BackColor = Color.White;                
                if (CountsP < Divisions) txtCountsP.BackColor = Color.LightPink;
                else txtCountsP.BackColor = Color.White;

                // Parse the values into strings and put them into the text boxes.
                txtCountsD.Text = CountsD.ToString();
                txtCountsP.Text = CountsP.ToString();
                // Calculate the error
                // Error Percent = (1 - (CountsD / RoundUp(CountsD))) * 100
                txtError.Text = Math.Round(((1-(CountsD / Math.Round(CountsD, MidpointRounding.AwayFromZero))) * 100), 2).ToString() + "%";
            }
            catch(Exception d)
            {
                MessageBox.Show("An error occured, please check your Frequency/PWM Freqency/Divisons and try again");
            }
        }
    }
}
