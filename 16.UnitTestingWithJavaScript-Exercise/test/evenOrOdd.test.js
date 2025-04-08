import { isOddOrEven } from '../01-EvenOrOdd/evenOrOdd.js'
import { expect } from 'chai'

describe('Test_evenOrOdd', () => {
    it('shoud return undefined if input is a number', () =>{
        // Arrange
        let input = 42;

        // Act
        let result = isOddOrEven(input)

        // Assert
        expect(result).to.undefined
    });
    it('shoud return undefined if input is null', () => {
        expect(isOddOrEven(null)).to.undefined
    });
    it('shoud return undefined if input is undefined', () => {
        expect(isOddOrEven(undefined)).to.undefined
    });
    it('shoud return even if input string is with even length', () =>{
        // Arrange
        let input = 'Hello!'
        let expected = 'even'

        // Act
        let result = isOddOrEven(input);

        // Assert
        expect(result).to.equal(expected)
    });
    it('shoud return odd if input string is with odd length', () =>{
        // Arrange
        let input = 'Hello'
        let expected = 'odd'

        // Act
        let result = isOddOrEven(input);

        // Assert
        expect(result).to.equal(expected)
    });
});