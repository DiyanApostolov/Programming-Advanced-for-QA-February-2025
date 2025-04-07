import { isSymmetric } from "../checkForSymmetry.js";
import { describe } from "mocha";
import { expect } from "chai";

describe("isSymmetric", () => {
  describe("negative cases", () => {
    it("returns false when non symetric data is passed", () => {
      expect(isSymmetric([1, 2, 3])).to.be.false;
      expect(isSymmetric(["1", 2, "3"])).to.be.false;
      expect(isSymmetric([["1"], 2, ["3"]])).to.be.false;
      expect(isSymmetric(["a", "b", "c"])).to.be.false;
    });

    it("returns false when non array data is passed", () => {
      expect(isSymmetric(1)).to.be.false;
      expect(isSymmetric(1, 2, 1)).to.be.false;
    });
  }),
    describe("positive cases", () => {
      it("returns true when array of symetric data is passed", () => {
        expect(isSymmetric([1, 2, 1])).to.be.true;
        expect(isSymmetric(["1", 2, "1"])).to.be.true;
        expect(isSymmetric([["1"], 2, ["1"]])).to.be.true;
        expect(isSymmetric(["a", "b", "a"])).to.be.true;
        expect(isSymmetric(["a", "b", "a", "a", "b", "a"])).to.be.true;
      });
    });
});
