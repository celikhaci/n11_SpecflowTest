Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: N11 Test
	Given  Url "https://www.n11.com/" adresine tıklanır.
	When   Kullanıcı giris yap butonuna tıklar on ".btnSignIn"
	When   Kullanıcı adı girilir "hacicelik0710@gmail.com" on "email"
	When   Şifre girilir "*********" on "password"
	When   Kullanıcı giriş yap butonuna tıklar on "loginButton"
	Then   Site Kapanır
	
	