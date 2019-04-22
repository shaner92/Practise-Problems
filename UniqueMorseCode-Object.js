/**
Uses dict/objects
 */
var uniqueMorseRepresentations = function(words) {
    let dict = {a:".-",b:"-...",c:"-.-.",d:"-..",e:".",f:"..-.",g:"--.",
                h:"....",i:"..",j:".---",k:"-.-",l:".-..",m:"--",n:"-.",
                o:"---",p:".--.",q:"--.-",r:".-.",s:"...",t:"-",u:"..-",
                v:"...-",w:".--",x:"-..-",y:"-.--",z:"--.."};
    let morseDict = {};
    words.forEach(function(word){
        let morseWord = "";
        for(var i=0; i<word.length; i++){
            morseWord += dict[word[i]];
        }
        morseDict[morseWord] = word;
    });
    let count = 0;
    for (var key in Object.keys(morseDict)){
        count++;
    }
    return count;
};