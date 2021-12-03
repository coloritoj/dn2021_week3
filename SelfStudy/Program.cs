using System;
using System.Collections.Generic;

namespace SelfStudy
{
    class RetirementAccount
    {
        public string Name;
        public int AmountSaved;
        public int PercentEachPaycheck;

        public RetirementAccount(string entryName, int entryAmountSaved, int entryPercentEachPaycheck)
        {
            Name = entryName;
            AmountSaved = entryAmountSaved;
            PercentEachPaycheck = entryPercentEachPaycheck;
        }

        public static List<RetirementAccount> listOfRetirementAccounts = new List<RetirementAccount>();

        public static void ListRetirementAaccounts(List<RetirementAccount> listOfAccounts)
        {
            for (int i = 0; i < listOfAccounts.Count; i++)
            {
                Console.WriteLine($"Retirement account {i + 1}... {listOfAccounts[i]}");
            }
        }
    }

    class Employer401k : RetirementAccount
    {
        public string EmployerName;

        public Employer401k(string entryName, int entryAmountSaved, int entryPercentEachPaycheck, string entryEmployerName) : base(entryName, entryAmountSaved, entryPercentEachPaycheck)
        {
            EmployerName = entryEmployerName;
        }
    }

    class Traditional401k : Employer401k
    {
        public string AccountType;
        private string TaxType;

        public Traditional401k(string entryName, int entryAmountSaved, int entryPercentEachPaycheck, string entryEmployerName, string entryTaxType) : base(entryName, entryAmountSaved, entryPercentEachPaycheck, entryEmployerName)
        {
            AccountType = "Traditional 401k";
            gsTaxType = entryTaxType;
        }

        public string gsTaxType
        {
            get
            {
                return TaxType;
            }
            set
            {
                if (value == "Pre-Tax" || value == "Pre Tax")
                {
                    TaxType = value;
                }
                else
                {
                    TaxType = "Invalid type entered";
                }
            }
        }

        public override string ToString()
        {
            return $"ACCOUNT HOLDER: {Name} | ACCOUNT TYPE: {AccountType} | TAX TYPE: {TaxType} | AMOUNT SAVED: ${AmountSaved} | PERCENT SAVED EACH PAYCHECK: {PercentEachPaycheck}% | EMPLOYER NAME: {EmployerName}";
        }
    }

    class Roth401k : Employer401k
    {
        public string AccountType;
        private string TaxType;

        public Roth401k(string entryName, int entryAmountSaved, int entryPercentEachPaycheck, string entryEmployerName, string entryTaxType) : base(entryName, entryAmountSaved, entryPercentEachPaycheck, entryEmployerName)
        {
            AccountType = "Roth 401k";
            TaxType = entryTaxType;
        }

        public string gsTaxType
        {
            get
            {
                return TaxType;
            }
            set
            {
                if (value == "Post-Tax" || value == "Post Tax")
                {
                    TaxType = value;
                }
                else
                {
                    TaxType = "Invalid type entered";
                }
            }
        }

        public override string ToString()
        {
            return $"ACCOUNT HOLDER: {Name} | ACCOUNT TYPE: {AccountType} | TAX TYPE: {TaxType} | AMOUNT SAVED: ${AmountSaved} | PERCENT SAVED EACH PAYCHECK: {PercentEachPaycheck}% | EMPLOYER NAME: {EmployerName}";
        }
    }

    class IRA : RetirementAccount
    {
        public string PlanSponsor;

        public IRA(string entryName, int entryAmountSaved, int entryPercentEachPaycheck, string entryPlanSponsor) : base(entryName, entryAmountSaved, entryPercentEachPaycheck)
        {
            PlanSponsor = entryPlanSponsor;
        }
    }

    class TraditionalIRA : IRA
    {
        public string AccountType;
        private string TaxType;

        public TraditionalIRA(string entryName, int entryAmountSaved, int entryPercentEachPaycheck, string entryPlanSponsor, string entryTaxType) : base(entryName, entryAmountSaved, entryPercentEachPaycheck, entryPlanSponsor)
        {
            AccountType = "Traditional IRA";
            gsTaxType = entryTaxType;
        }

        public string gsTaxType
        {
            get
            {
                return TaxType;
            }
            set
            {
                if (value == "Pre-Tax" || value == "Pre Tax")
                {
                    TaxType = value;
                }
                else
                {
                    TaxType = "Invalid type entered";
                }
            }
        }

        public override string ToString()
        {
            return $"ACCOUNT HOLDER: {Name} | ACCOUNT TYPE: {AccountType} | TAX TYPE: {TaxType} | AMOUNT SAVED: ${AmountSaved} | PERCENT SAVED EACH PAYCHECK: {PercentEachPaycheck}% | PLAN SPONSOR: {PlanSponsor}";
        }
    }

    class RothIRA : IRA
    {
        public string AccountType;
        private string TaxType;

        public RothIRA(string entryName, int entryAmountSaved, int entryPercentEachPaycheck, string entryPlanSponsor, string entryTaxType) : base(entryName, entryAmountSaved, entryPercentEachPaycheck, entryPlanSponsor)
        {
            AccountType = "Roth IRA";
            gsTaxType = entryTaxType;
        }

        public string gsTaxType
        {
            get
            {
                return TaxType;
            }
            set
            {
                if (value == "Post-Tax" || value == "Post Tax")
                {
                    TaxType = value;
                }
                else
                {
                    TaxType = "Ivalid type entered";
                }
            }
        }

        public override string ToString()
        {
            return $"ACCOUNT HOLDER: {Name} | ACCOUNT TYPE: {AccountType} | TAX TYPE: {TaxType} | AMOUNT SAVED: ${AmountSaved} | PERCENT SAVED EACH PAYCHECK: {PercentEachPaycheck}% | PLAN SPONSOR: {PlanSponsor}";
        }
    }

    class Program
    {
        static bool isValidAccountType(string entry)
        {
            if (entry == "traditional 401k")
            {
                return true;
            }
            else if (entry == "roth 401k")
            {
                return true;
            }
            else if (entry == "traditional ira")
            {
                return true;
            }
            else if (entry == "roth ira")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Roth401k roth401kAccountOne = new Roth401k("Josh Colorito", 44500, 15, "Burger King", "Post-Tax");
            RetirementAccount.listOfRetirementAccounts.Add(roth401kAccountOne);

            Traditional401k traditional401kAccountOne = new Traditional401k("Josh Colorito", 42100, 12, "GameStop", "Pre Tax");
            RetirementAccount.listOfRetirementAccounts.Add(traditional401kAccountOne);

            RothIRA rothIRAAccountOne = new RothIRA("Josh Colorito", 98922, 10, "Company XYZ", "Post-Tax");
            RetirementAccount.listOfRetirementAccounts.Add(rothIRAAccountOne);

            TraditionalIRA traditionalIRAccountOne = new TraditionalIRA("Josh Colorito", 12438, 11, "Company ABC", "Pre-Tax");
            RetirementAccount.listOfRetirementAccounts.Add(traditionalIRAccountOne);

            Console.WriteLine("Here is this initial list of retirement accounts:");
            RetirementAccount.ListRetirementAaccounts(RetirementAccount.listOfRetirementAccounts);

            Console.Write("\nWould you like to add another account to the list? (YES/NO): ");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {
                Console.WriteLine("\nPlease enter the following account information...");
                Console.Write("What kind of account is this? (TRADITIONAL 401k/ROTH 401k/TRADITIONAL IRA/ROTH IRA): ");
                string typeOfAccount = Console.ReadLine().ToLower();
                bool validAccount = isValidAccountType(typeOfAccount);

                string accountHolder = "";
                int amountSaved = 0;
                int percentSavedEachPaycheck = 0;
                string employerName = "";
                string planSponsor = "";
                string taxType = "";
                
                while (validAccount == false)
                {
                    Console.Write("Sorry, that was not a valid entry. What kind of account is this? (TRADITIONAL 401k/ROTH 401k/TRADITIONAL IRA/ROTH IRA): ");
                    typeOfAccount = Console.ReadLine().ToLower();
                    validAccount = isValidAccountType(typeOfAccount);
                }

                if (typeOfAccount == "traditional 401k")
                {
                    Console.Write($"Please enter the name of the account holder: ");
                    accountHolder = Console.ReadLine();
                    Console.Write($"Please enter the amount you have saved (no commas or special characters): ");
                    amountSaved = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the percentage you save each paycheck (no commas or special characters): ");
                    percentSavedEachPaycheck = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the name of your employer: ");
                    employerName = Console.ReadLine();
                    Console.Write($"Please enter the tax type: ");
                    taxType = Console.ReadLine();

                    Traditional401k nextTraditional401k = new Traditional401k(accountHolder, amountSaved, percentSavedEachPaycheck, employerName, taxType);
                    RetirementAccount.listOfRetirementAccounts.Add(nextTraditional401k);
                }
                else if (typeOfAccount == "roth 401k")
                {
                    Console.Write($"Please enter the name of the account holder: ");
                    accountHolder = Console.ReadLine();
                    Console.Write($"Please enter the amount you have saved (no commas or special characters): ");
                    amountSaved = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the percentage you save each paycheck (no commas or special characters): ");
                    percentSavedEachPaycheck = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the name of your employer: ");
                    employerName = Console.ReadLine();
                    Console.Write($"Please enter the tax type: ");
                    taxType = Console.ReadLine();

                    Roth401k nextRoth401k = new Roth401k(accountHolder, amountSaved, percentSavedEachPaycheck, employerName, taxType);
                    RetirementAccount.listOfRetirementAccounts.Add(nextRoth401k);
                }
                else if (typeOfAccount == "traditional ira")
                {
                    Console.Write($"Please enter the name of the account holder: ");
                    accountHolder = Console.ReadLine();
                    Console.Write($"Please enter the amount you have saved (no commas or special characters): ");
                    amountSaved = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the percentage you save each paycheck (no commas or special characters): ");
                    percentSavedEachPaycheck = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the name of your plan sponsor: ");
                    planSponsor = Console.ReadLine();
                    Console.Write($"Please enter the tax type: ");
                    taxType = Console.ReadLine();

                    TraditionalIRA nextTraditionalIRA = new TraditionalIRA(accountHolder, amountSaved, percentSavedEachPaycheck, planSponsor, taxType);
                    RetirementAccount.listOfRetirementAccounts.Add(nextTraditionalIRA);
                }
                else if (typeOfAccount == "roth ira")
                {
                    Console.Write($"Please enter the name of the account holder: ");
                    accountHolder = Console.ReadLine();
                    Console.Write($"Please enter the amount you have saved (no commas or special characters): ");
                    amountSaved = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the percentage you save each paycheck (no commas or special characters): ");
                    percentSavedEachPaycheck = int.Parse(Console.ReadLine());
                    Console.Write($"Please enter the name of your plan sponsor: ");
                    planSponsor = Console.ReadLine();
                    Console.Write($"Please enter the tax type: ");
                    taxType = Console.ReadLine();

                    RothIRA nextRothIRA = new RothIRA(accountHolder, amountSaved, percentSavedEachPaycheck, planSponsor, taxType);
                    RetirementAccount.listOfRetirementAccounts.Add(nextRothIRA);
                }
            }

            Console.WriteLine("\nHere is this updated list of retirement accounts:");
            RetirementAccount.ListRetirementAaccounts(RetirementAccount.listOfRetirementAccounts);
        }
    }
}

// TOPICS FOR SELF-STUDY:
// Classes --- COMPLETE
// Public and Private --- COMPLETE
// Getter and Setter Functions --- COMPLETE
// Static Members
// Practice Constructors --- COMPLETE
// One class derived from another class --- COMPLETE
// Practice constructors in derived classes --- COMPLETE
// Practice putting a class and derived class instances in a list --- COMPLETE
