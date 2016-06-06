==========
netocbc
==========


==========
Installing
==========

You can get the source code from here

.. code:: shell

    $ git clone https://github.com/connect2ocbc/netoccbc.git && cd netocbc
    $ You will need Visual Studio 2010 and above to compile this project

==========
How to run
==========

.. code:: shell

	Forex forex = new Forex("https://api.ocbc.com:8243/Forex/1.0", "<TOKEN");
	foreach (Rate rate in forex.all())
	{
		Console.WriteLine(rate.ToString());
	}
                       
	Branches branches = new Branches("https://api.ocbc.com:8243/branch_locator/1.0", "<TOKEN");
	foreach (Branch branch in branches.all())
	{
		Console.WriteLine(branch.ToString());
	}
            
	Atms atms = new Atms("https://api.ocbc.com:8243/atm_locator/1.0", "<TOKEN");
	foreach (Atm atm in atms.all())
	{
		Console.WriteLine(atm.ToString());
	}

	CCSuggest cc = new CCSuggest("https://api.ocbc.com:8243/CC/1.0", "<TOKEN");
	foreach (CreditCard creditcard in cc.suggest("Dining"))
	{
		Console.WriteLine(creditcard.ToString());
	}
