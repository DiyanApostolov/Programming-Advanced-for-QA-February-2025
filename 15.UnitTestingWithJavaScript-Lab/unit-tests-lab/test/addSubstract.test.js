import { createCalculator } from "../addSubtract.js";
import { expect } from "chai";

describe("createCalculator", () => {
  let calculator;

  beforeEach(() => {
    calculator = createCalculator();
  });

  it("should add numbers correctly", () => {
    calculator.add(5);
    expect(calculator.get()).to.equal(5);
  });

  it("should subtract numbers correctly", () => {
    calculator.subtract(2);
    expect(calculator.get()).to.equal(-2);
  });

  it("should parse string numbers correctly", () => {
    calculator.add("7");
    expect(calculator.get()).to.equal(7);
  });

  it("should not modify value directly from outside", () => {
    expect(calculator.value).to.be.undefined;
  });
});
