using Godot;
using System;

public class TextureButton : Godot.Control
{

	private Label tempo;
	private Label key;
	private Label genre;

	private string[] keyList = new string[] {
		"C/Am",
		"G/Em",
		"Eb/Cm",
		"F/Dm",
		"D/Bm",
		"A/F#m",
		"E/C#m",
		"Db/Bbm",
		"Bb/Gm",
		"Ab/Fm",
		"B/G#m",
		"F#/D#m",
		"fuck key",
		"u decide"
	};

	private string[] first = new string[] {
		"half-time", "double-time", "fresh", "pee-sounding", "hard hittin'", "old fashioned", "vintage", "trashy", "straight", "gay", "asexual", "wet",
		"the worst", "garbage", "swedish", "questionable", "dry fart", "hard", "bricked up", "shady", "heavy", "overcompressed", "colonial", "sus", "foamy",
		"adult", "nosebleed", "elderly", "political", "transdimensional", "super", "alcoholic", "drug-infused", "insane", "feminine", "masculine", "dumb",
		"ice cold", "woke", "cum-covered", "waka-waka", "rich", "right-wing", "communist", "big pharma", "über", "soft", "lusty", "vegan",
		"shitty", "60's", "70's", "80's", "90's", "humanitarian", "vegetarian", "royal", "the worst", "tasty", "juicy", "flaming hot", "huuuuuge",
		"nerdy", "homophobic", "moist", "sinful", "peaceful", "depressing", "general", "stressful", "chill", "stiff", "ott", "alien", "newsworthy",
		"japanese", "insanely big", "watery", "very naughty", "pg-13", "unrelenting", "fired up", "spectacular", "anime", "school shooter",
		"smol", "playful", "pseudo-intellectual", "imaginary", "middle eastern", "reverse", "really loud", "overrated", "calm", "underwhelming", "ironic",
		"horny", "dead serious", "step sibling", "victorian", "illegal", "left-wing"
	};

	private string[] second = new string[] {
		"bro", "dub", "cum", "cream", "piss", "shit", "fart", "anal", "straight", "gay", "senpai", "goo", "indie", "drum", "bulge", "animal", "lolipop",
		"cummy", "dick", "flem", "masturbation", "deep", "progressive", "regressive", "agressive", "future", "sweat", "folk", "hyper", "e-sport",
		"electro", "kawaii", "reggae", "sauce", "cunt", "german", "deepthroat", "euro", "diarrhea", "soul", "melodic", "uk", "bread", "penis", "pee",
		"furry", "yiff", "futa", "death", "vag", "elevator", "foot", "videogame", "minimal", "hardcore", "post", "cock", "drug", "classical", "vapor", "butt",
		"dumster", "uwu", "oatmeal", "egg", "synth", "bunghole", "big booty", "handjob", "cowboy", "cowgirl", "sosig", "murder", "ass", "rock",
		"bollywood"
	};

	private string[] third = new string[] {
		" bass", "-step", " riddim", " house", " n' roll", " n' bass", " moombahton", " blues", " rock", "-wave", " dankwave", " disco",
		"core", " emo", "-pop", " techno", " dance", " breakbeat", " grime", " club music", " electronica", " trance", " mainstage", " psy", " chill", " garage",
		" twerk", " crunk", "-style", " swing", " edm", " funk", " reggae", " jingle", " movie score", " orchestral", " metal", " country", " glitch", "-hop",
		" tango", " salsa", " bigroom", " punk", " big band", " rap", " theme song", " choir", " screamo", " rockabilly", " rave"
	};


	public override void _Ready()
	{
		tempo = (Label)GetNode("/root/Main/VBoxContainer/tempo");
		key = (Label)GetNode("/root/Main/VBoxContainer/key");
		genre = (Label)GetNode("/root/Main/VBoxContainer/genre");
	}


	private void ButtonPressed()
	{
		var randomBpm = new RandomNumberGenerator();
		randomBpm.Randomize();

		var r1 = new RandomNumberGenerator();
		r1.Randomize();
		var n1 = r1.Randi() % keyList.Length;

		var r2 = new RandomNumberGenerator();
		r2.Randomize();
		var n2 = r2.Randi() % first.Length;

		var r3 = new RandomNumberGenerator();
		r3.Randomize();
		var n3 = r3.Randi() % second.Length;

		var r4 = new RandomNumberGenerator();
		r4.Randomize();
		var n4 = r4.Randi() % third.Length;

		tempo.Text = "tempo: " + randomBpm.RandiRange(70, 174).ToString();
		key.Text = "key: " + keyList[n1].ToString();
		genre.Text = "genre: \t" + first[n2] + " " + second[n3] + third[n4];
		//GD.Print("genre: " + first[n2] + " " + second[n3] + third[n4]);
	}


}
