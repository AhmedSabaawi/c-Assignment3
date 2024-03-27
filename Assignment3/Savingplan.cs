using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BMICalculator
{

    // Savingplan class
    public class Savingplan
    {



      
    // private instance variable
    private double _initialDeposit;
    private double _monthlySaving;
    private int _period;
    private double _growth;
    private double _fees;

    // Defult constructor 
     
    public Savingplan()
        {
        _initialDeposit = 0;
        _monthlySaving = 0;
        _period = 0;
        _growth = 0;
        _fees = 0;
    }


        // add method to calculate the future value of the saving plan

    public double totalAmountPaid2()
        {
            //Balance = initial deposit + monthly saving amount(start balance end of first month)
            //Months = period(years) * 12.
            //Monthly interest = interest rate in % (input) / 100.0 / 12
            //Monthly fees = fees in % (input) / 100 / 12
            //For(month = 1 to Months)
            //Calculate interest(monthly interest *balance)
            //fees = fees * balance
            //Balance += interest – fees + monthly saving
            //total interest += interest
            //total fees += fees
            //Total amount paid = initial balance + (months * monthly saving)

            double balance = _initialDeposit + _monthlySaving;
            int months = _period * 12;
            double monthlyInterest = _growth / 100.0 / 12;
            double monthlyFees = _fees / 100.0 / 12;
            double totalInterest = 0;
            double totalFees = 0;
            double totalAmountPaid = _initialDeposit + (months * _monthlySaving);

            for (int month = 1; month <= months; month++)
            {
                double interest = monthlyInterest * balance;
                double fees = monthlyFees * balance;
                balance += interest - fees + _monthlySaving;
                totalInterest += interest;
                totalFees += fees;
            }

            // return the future values
            return balance;


    }


        public double totalAmountPaid()
        {
            return _initialDeposit + (_monthlySaving * _period * 12);
        }


        public double AmountEarned()
        {
            double balance = _initialDeposit + _monthlySaving;
            int months = _period * 12;
            double monthlyInterest = _growth / 100.0 / 12;
            double totalInterest = _initialDeposit;

            for (int month = 2; month <= months; month++)
            {
                double interest = monthlyInterest * balance;
                balance += interest + _monthlySaving; // Update balance for accurate interest calculation
                totalInterest += interest;
            }

            return totalInterest;
        }



        public double finalBalance()
        {
            double balance = _initialDeposit; // Start with the initial deposit
            int months = _period * 12;
            double monthlyInterestRate = _growth / 100.0 / 12; // Convert annual rate to monthly

            for (int month = 1; month <= months; month++)
            {
                balance *= (1 + monthlyInterestRate); // Apply interest to the balance
                balance += _monthlySaving; // Add monthly saving after interest has been applied
            }

            return balance; // Return the final balance after all calculations
        }
        public double TotalFees()
        {
            double balance = _initialDeposit + _monthlySaving;
            int months = _period * 12;
            double monthlyFees = _fees / 100.0 / 12;
            double totalFees = 0;

            for (int month = 1; month <= months; month++)
            {
                double fees = monthlyFees * balance;
                balance += _monthlySaving; // Only add monthly saving, as we're not interested in interest for fee calculation
                totalFees += fees;
            }

            return totalFees;
        }

        #region Getters and Setters
        // add getters and setters and check for valid input

        public double InitialDeposit
        {
            get
            {
                return _initialDeposit;
            }
            set
            {
                if (value >= 0)
                {
                    _initialDeposit = value;
                }
            }
        }

        public double MonthlySaving
        {
            get
            {
                return _monthlySaving;
            }
            set
            {
                if (value >= 0)
                {
                    _monthlySaving = value;
                }
            }
        }

        public int Period
        {
            get
            {
                return _period;
            }
            set
            {
                if (value >= 0)
                {
                    _period = value;
                }
            }
        }


        public double Growth
        {
            get
            {
                return _growth;
            }
            set
            {
                if (value >= 0)
                {
                    _growth = value;
                }
            }
        }

        public double Fees
        {
            get
            {
                return _fees;
            }
            set
            {
                if (value >= 0)
                {
                    _fees = value;
                }
            }
        }

    #endregion


    }


}
