import { artGallery } from '../05-ArtGallery/artGallery.js'
import { expect } from 'chai'

describe('Test_artGallery', () => {
    describe('addArtwork', () => {
        it('shoud throw an error if title is not a string', () => {
            expect(() => artGallery.addArtwork(42, '30 x 60', 'Monet')).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork(null, '30 x 60', 'Monet')).to.throw("Invalid Information!")
        })
        it('shoud throw an error if artist name is not a string', () => {
            expect(() => artGallery.addArtwork('Water lilies', '30 x 60', 42)).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork('Water lilies', '30 x 60', null)).to.throw("Invalid Information!")
        })
        it('shoud throw an error if dimensions is not a valid value string', () => {
            expect(() => artGallery.addArtwork('Water lilies', '30x20', 'Monet')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Water lilies', null, 'Monet')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Water lilies', '30a x 20', 'Monet')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Water lilies', '30 x 20#', 'Monet')).to.throw("Invalid Dimensions!")
        })
        it('shoud throw an error if artist is not a valid artist', () => {
            expect(() => artGallery.addArtwork('Water lilies', '30 x 60', 'Vladimir Dimitrov - maystora')).to.throw("This artist is not allowed in the gallery!");
        })
        it('shoud return message if all parameters are valid', () => {
            let message = `Artwork added successfully: 'Water lilies' by Monet with dimensions 30 x 60.`;

            expect(artGallery.addArtwork('Water lilies', '30 x 60', 'Monet')).to.equal(message)
        })
    });

    describe('calculateCosts', () => { 
        it('should throw error for empty input', () => {
            expect(() => artGallery.calculateCosts()).to.throw("Invalid Information!")
        });
        it('should throw error for incorrect exhibition costs', () => {
            expect(() => artGallery.calculateCosts("costs", 100, true)).to.throw("Invalid Information!")
        });
        it('should throw error for incorrect insurance costs', () => {
            expect(() => artGallery.calculateCosts(100, "costs", true)).to.throw("Invalid Information!")
        });
        it('should throw error for incorrect sponsor', () => {
            expect(() => artGallery.calculateCosts(500, 100, 50)).to.throw("Invalid Information!")
        });
        it('should throw error for invalid exhibition costs', () => {
            expect(() => artGallery.calculateCosts(-500, 100, true)).to.throw("Invalid Information!")
        });
        it('should throw error for incorrect insurance costs', () => {
            expect(() => artGallery.calculateCosts("costs", -100, true)).to.throw("Invalid Information!")
        });

        it('should return correct message - no sponsor', () => {
            expect(artGallery.calculateCosts(1000, 100, false)).to.equal("Exhibition and insurance costs are 1100$.")
        });
        it('should return correct message - with sponsor', () => {
            expect(artGallery.calculateCosts(1000, 100, true)).to.equal("Exhibition and insurance costs are 990$, reduced by 10% with the help of a donation from your sponsor.")
        });
    });

    describe('organizeExhibits', () => { 
        it('should throw error for incorrect artworksCount', () => {
            expect(() => artGallery.organizeExhibits("count", 20)).to.throw("Invalid Information!")
        });
        it('should throw error for incorrect displaySpacesCount', () => {
            expect(() => artGallery.organizeExhibits(10, "spaces")).to.throw("Invalid Information!")
        });
        it('should throw error for invalid artworksCount', () => {
            expect(() => artGallery.organizeExhibits(-10, 20)).to.throw("Invalid Information!")
        });
        it('should throw error for invalid displaySpacesCount', () => {
            expect(() => artGallery.organizeExhibits(10, -20)).to.throw("Invalid Information!")
        });

        it('should return correct message - artworksPerSpace < 5', () => {
            expect(artGallery.organizeExhibits(80, 20)).to.equal("There are only 4 artworks in each display space, you can add more artworks.")
        });
        it('should return correct message - artworksPerSpace >= 5', () => {
            expect(artGallery.organizeExhibits(100, 20)).to.equal("You have 20 display spaces with 5 artworks in each space.")
        });

    });
});