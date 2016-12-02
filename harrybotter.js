var restify = require('restify');
var builder = require('botbuilder');


// Creation du bot botter
var connector = new builder.ChatConnector({
	appId: "Nuitde",
	appPassword: "l'info"
});
var bot = new builder.UniversalBot(connector);
bot.dialog('/', function (session) {
	session.send('Expecto Patronum!!!');
});

// Configuration du serveur
var server = restify.createServer();
server.post('/api/messages', connector.listen());
server.listen(process.env.port || 3978, function () {
	console.log('%s listening to %s', server.name, server.url);
});
