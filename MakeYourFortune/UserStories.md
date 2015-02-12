Given the MakeYourFortune page is visible,
a Cookie Creator in order to submit a cookie, 
When the creator clicks on the textbox,
Then the textbox will become blank,
When he populates the textbox,
AND he must select a combobox category,
Then th submit button will be enabled
When he will click the submit button
Then alert will say the fortune cookie has been submitted.
And then textbox will clear back to message.


void ThenTextBoxisFilled(){
TestStack.White.InputDevices.AttachedKeyboard keyboard = window.Keyboard;
http://www.dreamincode.net/forums/topic/322108-c%23-teststackwhite-for-beginners/
keyboard.Enter("Hello");
Assert.Equal...
}

   void AndThentheComboBoxCategoryisSelected() { }
       void ThentheSubmitButtonisEnabled() { }
       void ThenSubmitButtonisPressed() { }
       void AndAnAlertisShowntoVerify() { }
       void AndSubmitButtonisDisabled() { }
       void AndTextBoxBacktoDefault() { }
       void FortuneisEnteredinDB() { }





