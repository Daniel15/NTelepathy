using System;

namespace NTelepathy.Example
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			AccountManager manager = Telepathy.AccountManager;
					
			foreach (Account account in manager.ValidAccounts)
			{
				account.Connection.SetPresence("available", "Hello World");
			}
		}
	}
}
