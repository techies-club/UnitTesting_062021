/* eslint-disable prettier/prettier */
import { mount } from "@vue/test-utils";
import PasswordStrengthChecker  from "@/components/PasswordStrengthChecker"; //no {} for importing default exported module

describe("test password strenght feature", () => {
  const passwordWrapper = mount(PasswordStrengthChecker);
  it("password component loaded", () => {
    expect(passwordWrapper.html()).toContain("Password Strength Checker");
  });

  //test password strength => Strong scenario
  it("strong password check",()=>{
    let strongPassword = "aZ@11223344";
    passwordWrapper.setData({password:strongPassword});
    const passwordText = passwordWrapper.find("#PassEntry");
    passwordText.trigger("blur");
    expect(passwordWrapper.vm.$data.strengthBadge).toBe("Strong");   
  });
//test password strength => Medium scenario
  it("medium password check",()=>{
    let MediumPassword = "aZ@1123";
    passwordWrapper.setData({password:MediumPassword});
    const passwordText = passwordWrapper.find("#PassEntry");
    passwordText.trigger("blur");
    expect(passwordWrapper.vm.$data.strengthBadge).toBe("Medium");   
  });

});
