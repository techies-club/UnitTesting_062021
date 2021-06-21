import { mount } from "@vue/test-utils";
import axios from "axios";
import userComponent from "@/components/userComponent";

const userServiceModule = require("../../src/userService");

jest.mock("axios"); //If you do this, your actual service calls through axios will be omitted

describe("check menu", () => {
  const userComponentWrapper = mount(userComponent);
  it("Component mount check", () => {
    expect(userComponentWrapper.html()).toContain("User Module");
  });

  const emalId = "oleander@gmail.com";
  
  //Below test will fail if line #7 (jest.mock("axios");) is commented
  it("returns a mock user from service", async () => {
    axios.get.mockResolvedValue({
      data: [
        {
          id: 4,
          firstname: "Yuba",
          lastname: "Oleander",
          email: "oleander@gmail.com",
        },
        {
          id: 1,
          firstname: "Munonye",
          lastname: "Kindson",
          email: "kany@gmail.com",
        },
      ],
    });
    const user = await userServiceModule.validateEmail(emalId);
    expect(user.data[0].firstname).toEqual("Yuba");
  });

  //Below test will fail if line #7 (jest.mock("axios");) is un commented
  it("Test user service validates user by email: actual service call:", async () => {
    const user = await userServiceModule.validateEmail(emalId); // Run the function
    // console.log(user);
   if (user) {
      expect(user.data.length).toBeGreaterThan(0); // Make an assertion on the result
   }
  });


  /* TODO:
  it("Menu check for registered user", async () => {
    const user = {
        [{
            "id": 4,
            "firstname": "Yuba",
            "lastname": "Oleander",
            "email": "oleander@gmail.com"
        }]     
    };
    userComponentWrapper.setData({ email: "oleander@gmail.com" });
    const btnValidateMe = userComponentWrapper.find("#btnValidate");
    btnValidateMe.trigger("click");

    axios.get.mockImplementationOnce(() => Promise.resolve(user));
*/

  //await flushPromises();
  // userComponentWrapper.vm.$nextTick(() => {
  //   console.log(userComponentWrapper.find("#aMember").text());
  //   expect(userComponentWrapper.vm.$data.isValidUser).toBe(true);
  //   expect(userComponentWrapper.find("#aMember").text()).toContain(
  //     "Register Me"
  //   );
  // });
});
