const fs = require('fs');
// fs.writeFileSync('demo.txt', 'Hello, this is a demo text file.');
// console.log('File created and written successfully.');
const data = fs.readFileSync('demo.txt', 'utf8');
console.log('File Content:', data);

fs.appendFileSync('demo.txt', '\nThis is an appended line.');
console.log('Text appended successfully.');

fs.renameSync('demo.txt', 'new-demo.txt');
console.log('File renamed successfully.');


fs.unlinkSync('new-demo.txt');
console.log('File deleted successfully.');
