// See https://aka.ms/new-console-template for more information

using Fizzbuzz_Core_Design_Pattern.Fizzbuzz;

var game = new FizzbuzzGame(0, 100);
var context = new FizzbuzzContext();
game.AssignGameToContext(context);
game.Play();