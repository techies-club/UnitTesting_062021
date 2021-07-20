/// <reference types="cypress" />

describe("Test My app End to End", () => {
  beforeEach(() => {
    //Open the URL before each test case
    cy.visit("http://localhost:8080/#/");
  });

  it("Has Login & Register Link in it", () => {
    //Find the control and check if it shows expected data when page is loaded
    cy.get("[data-testid=login]").contains("Login"); //use small letter (data-testid=login)
    cy.get("[data-testid=register]").contains("Register");
  });

  it("Click login redirects to login page", () => {
    //Find the control and check if it shows expected data when page is loaded
    cy.get("[data-testid=login]").click(); //click login

    //login page is loaded
    cy.url().should("include", "http://localhost:8080/#/login");
  });
  it("Test login failure", () => {
    cy.get("[data-testid=login]").click(); //click login
    //set data
    cy.get("[data-testid=loginid]").type("xx"); //give input
    cy.get("[data-testid=loginpin]").type("12");
    cy.get("[data-testid=loginbutton]").click(); //click login button
    //check error
    cy.get("[data-testid=error]").contains("Invalid login"); //check error message
  });
  it("Test login success", () => {
    cy.get("[data-testid=login]").click(); //click login
    //set data
    cy.get("[data-testid=loginid]").type("xxx"); //give input
    cy.get("[data-testid=loginpin]").type("123");
    cy.get("[data-testid=loginbutton]").click(); //click login button
    //check about page is loaded
    cy.url().should("include", "http://localhost:8080/#/about");
  });
  //TEST CASE FOR REGISTERATION WITH MATCHING PIN AND RE-PIN USING COPY-PASTE
  it("Test REGISTERATION pin mismatch", () => {
    cy.get("[data-testid=register]").click(); //click register
    //set data
    cy.get("[data-testid=loginid]").type("xxx"); //give input
    cy.get("[data-testid=loginpin]").type("12");
    cy.get("[data-testid=loginrepin]").type("123");

    cy.get("[data-testid=registerbutton]").click(); //click register button
    //check error
    cy.get("[data-testid=error]").contains("confirm pin"); //check error message
  });
  //TEST CASE FOR REGISTERATION success
  it("Test REGISTERATION successful redirect to about", () => {
    cy.viewport("iphone-8"); //change the device
    cy.get("[data-testid=register]").click(); //click register
    //set data
    cy.get("[data-testid=loginid]").type("xxx"); //give input
    cy.get("[data-testid=loginpin]").type("12");    
   
      //TODO :FIX this ctrl command
      //.type("{ctrl}{a}") //select all
      //.type("{selectall}")
      //.type("{ctrl c}")
     // .rightclick()
     //.contains("copy").click(); //copy
     
    //cy.get("[data-testid=loginrepin]")//.type("{ctrl}{v}"); //paste
    //document.execCommand('paste')

    cy.get("[data-testid=loginrepin]").type("12")
    cy.get("[data-testid=registerbutton]").click(); //click register button
    //check error
    cy.url().should("include", "http://localhost:8080/#/about"); //about is loaded
  });
});
