import { sum } from "../sumNumbers.js";
import { describe } from "mocha";
import { expect } from "chai";

describe("sum", () => {
  // chaching errors
  // // to expect(() => func(args)).to.throw("error message");
  //   it("test chacing error ", () => {
  //     expect(() => sum([1])).to.throw("Invalid Information!");
  //   });
    it("should return same number when single input is passed", () => {
      // arrange
      let input = [1];
      let expected = 1;
      // act
      let actual = sum(input);
      // assert
      expect(actual).to.equal(expected);
    });
    it("should returns correct sum when two positive numers are passed", () => {
      // arrange
      let input = [1, 2];
      let expected = 3;
      // act
      let actual = sum(input);
      // assert
      expect(actual).to.equal(expected);
    });
});
