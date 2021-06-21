/* eslint-disable prettier/prettier */
//1. import vue test utils
import { mount } from "@vue/test-utils";
//2. import component to test
import Counter from "@/components/Counter";

//3. Describe your test
describe("Test counter component", () => {
  //4. Create wrapper of component to interact with
  const counterWrapper = mount(Counter);
  //5. Define your test case
  it("has total text in it", () => {
    //6. validate actual with your expectation
    expect(counterWrapper.html()).toContain("Total");
  });
  //Check initial sum value is 0
  it("initial counter value is 0", () => {
    expect(counterWrapper.vm.$data.sum).toBe(0);
  });
  //Fire event and check value
  it("counter is working on button click", () => {
    const sumButton = counterWrapper.find("button");
    sumButton.trigger("click");
    sumButton.trigger("click");
    sumButton.trigger("click");
    expect(counterWrapper.vm.$data.sum).toBe(3);
  });
});
