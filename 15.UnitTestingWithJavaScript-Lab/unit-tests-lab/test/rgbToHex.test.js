import { rgbToHexColor } from "../rgb-to-hex.js";
import { expect } from "chai";

describe("rgbToHexColor", () => {
  it("return irght color when valid data", () => {
    expect(rgbToHexColor(0, 0, 0)).to.equal("#000000"); // Black
    expect(rgbToHexColor(255, 255, 255)).to.equal("#FFFFFF"); // White
  });

  it("return undefined when invalid data", () => {
    expect(rgbToHexColor(100, 100, 256)).to.be.undefined;
    expect(rgbToHexColor(-1, 100, 100)).to.be.undefined;
    expect(rgbToHexColor("255", 255, 255)).to.be.undefined;
    expect(rgbToHexColor(255)).to.be.undefined;
  });
});
