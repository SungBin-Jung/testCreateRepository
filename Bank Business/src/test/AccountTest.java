package test;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class AccountTest {
	private Account account;
	@Test
	public void testAccount() throws Exception {
		account = new Account();
		if(account == null) {
			throw new Exception("계좌생성 실패");
		}
	}
	@Test
	public void testGetBalance() throws Exception {
		setUp();
		
		assertEquals(10000,account.getBalance());
		account = new Account(1000);
		assertEquals(1000,account.getBalance());
		account = new Account(0);
		assertEquals(0,account.getBalance());
	}
	private void setUp() {
		account = new Account(10000);
	}
	
	@Test
	public void testDeposit() throws Exception {
		setUp();
		account.deposit(1000);
		assertEquals(11000,account.getBalance());
	}
	@Test
	public void testWithdraw() throws Exception {
		setUp();
		account.withdraw(1000);
		assertEquals(9000,account.getBalance());
	}
	/*public static void main(String[] args) {
		AccountTest test = new AccountTest();
		try {
			test.testAccount();
		} catch (Exception e) {
			System.out.println("실패(X)");
			return;
		}
		System.out.println("성공(O)");
	}*/
}
