import { lookupChar } from '../02-CharLookUp/charLoockUp.js'
import { expect } from 'chai'

describe('Test_loockupChar', () => {
    it('shoud return undefined if first parameter is not a string', () => {
        expect(lookupChar(null, 2)).to.undefined
        expect(lookupChar(42, 2)).to.undefined
    });
    it('shoud return undefined if second parameter is not an integer number', () => {
        expect(lookupChar('Hello', '3')).to.undefined
        expect(lookupChar('Hello', 'a')).to.undefined
        expect(lookupChar('Hello', '#')).to.undefined
        expect(lookupChar('Hello', 3.5)).to.undefined
        expect(lookupChar('Hello', null)).to.undefined
    });
    it('shoud return Incorrect index if index is a negative value', () => {
        // Arrange
        let expected = 'Incorrect index';

        //Act & Assert
        expect(lookupChar('Hello', -1)).to.equal(expected)
    });

    it('shoud return Incorrect index if index is equal or greater that text length', () => {
        // Arrange
        let expected = 'Incorrect index';

        //Act & Assert
        expect(lookupChar('Hello', 5)).to.equal(expected)
        expect(lookupChar('Hello', 10)).to.equal(expected)
    });
    it('shoud return charm at the specific index if parameters are valid', () => {
        expect(lookupChar('Hello', 0)).to.equal('H')
        expect(lookupChar('Hello', 1)).to.equal('e')
        expect(lookupChar('Hello', 4)).to.equal('o')
    });
});
