open System

let r = Random()

let random a b =
    r.Next(a, b)

let animals = [|
    "aardvark"; "albatross"; "alligator"; "alpaca"; "ant"; "anteater"; "antelope"; 
    "ape"; "armadillo"; "baboon"; "badger"; "barracuda"; "bat";
    "bear"; "beaver"; "bee"; "bison"; "boar"; "buffalo"; "butterfly"; 
    "camel"; "capybara"; "caribou"; "cassowary"; "cat"; "caterpillar"; "cattle"; 
    "chamois"; "cheetah"; "chicken"; "chimpanzee"; "chinchilla"; "chough"; "clam"; 
    "cobra"; "cockroach"; "cod"; "cormorant"; "coyote"; "crab"; "crane"; 
    "crocodile"; "crow"; "curlew"; "deer"; "dinosaur"; "dog"; "dogfish"; 
    "dolphin"; "donkey"; "dotterel"; "dove"; "dragonfly"; "duck"; "dugong"; 
    "dunlin"; "eagle"; "echidna"; "eel"; "eland"; "elephant"; "elephant-seal"; 
    "elk"; "emu"; "falcon"; "ferret"; "finch"; "fish"; "flamingo"; 
    "fly"; "fox"; "frog"; "gaur"; "gazelle"; "gerbil"; "giant-panda"; 
    "giraffe"; "gnat"; "gnu"; "goat"; "goose"; "goldfinch"; "goldfish"; 
    "gorilla"; "goshawk"; "grasshopper"; "grouse"; "guanaco"; "guinea-fowl"; "guinea-pig"; 
    "gull"; "hamster"; "hare"; "hawk"; "hedgehog"; "heron"; "herring"; 
    "hippopotamus"; "hornet"; "horse"; "human"; "hummingbird"; "hyena"; "ibex"; 
    "ibis"; "jackal"; "jaguar"; "jay"; "jellyfish"; "kangaroo"; "kingfisher"; 
    "koala"; "komodo-dragon"; "kookabura"; "kouprey"; "kudu"; "lapwing"; "lark"; 
    "lemur"; "leopard"; "lion"; "llama"; "lobster"; "locust"; "loris"; 
    "louse"; "lyrebird"; "magpie"; "mallard"; "manatee"; "mandrill"; "mantis"; 
    "marten"; "meerkat"; "mink"; "mole"; "mongoose"; "monkey"; "moose"; 
    "mouse"; "mosquito"; "mule"; "narwhal"; "newt"; "nightingale"; "octopus"; 
    "okapi"; "opossum"; "oryx"; "ostrich"; "otter"; "owl"; "ox"; 
    "oyster"; "panther"; "parrot"; "partridge"; "peafowl"; "pelican"; "penguin"; 
    "pheasant"; "pig"; "pigeon"; "polar-bear"; "pony"; "porcupine"; "porpoise"; 
    "prairie-dog"; "quail"; "quelea"; "quetzal"; "rabbit"; "raccoon"; "rail"; 
    "ram"; "rat"; "raven"; "red-deer"; "red-panda"; "reindeer"; "rhinoceros"; 
    "rook"; "salamander"; "salmon"; "sand-dollar"; "sandpiper"; "sardine"; "scorpion"; 
    "sea-lion"; "sea-urchin"; "seahorse"; "seal"; "shark"; "sheep"; "shrew"; 
    "skunk"; "snail"; "snake"; "sparrow"; "spider"; "spoonbill"; "squid"; 
    "squirrel"; "starling"; "stingray"; "stinkbug"; "stork"; "swallow"; "swan"; 
    "tapir"; "tarsier"; "termite"; "tiger"; "toad"; "trout"; "turkey"; 
    "turtle"; "vicuña"; "viper"; "vulture"; "wallaby"; "walrus"; "wasp"; 
    "water-buffalo"; "weasel"; "whale"; "wolf"; "wolverine"; "wombat"; "woodcock"; 
    "woodpecker"; "worm"; "wren"; "yak"; "zebra";
    "dragon"; "unicorn"; "griffin"; "phoenix"; "centaur"; "minotaur"; "chimera";
    "hydra"; "kraken"; "yeti"; "cerberus"; "pegasus"; "basilisk";
    "harpy"; "hippogriff"; "satyr"; "cyclops"; "gorgon"; "manticore";
    "sphinx";
|]

let adjectives = [|
    "able"; "above"; "absent"; "absolute"; "abstract"; "abundant"; "academic";
    "acceptable"; "accepted"; "accessible"; "accurate"; "accused"; "active";
    "actual"; "acute"; "added"; "additional"; "adequate"; "adjacent"; "administrative";
    "adorable"; "advanced"; "adverse"; "advisory"; "aesthetic"; "afraid"; "aggregate";
    "aggressive"; "agreeable"; "agreed"; "agricultural"; "alert"; "alive";
    "alleged"; "allied"; "alone"; "alright"; "alternative"; "amateur"; "amazing";
    "ambitious"; "amused"; "ancient"; "angry"; "annoyed"; "annual"; "anonymous";
    "anxious"; "appalling"; "apparent"; "applicable"; "appropriate"; "arbitrary";
    "architectural"; "armed"; "arrogant"; "artificial"; "artistic"; "ashamed";
    "asleep"; "assistant"; "associated"; "atomic"; "attractive"; "automatic";
    "autonomous"; "available"; "average"; "awake"; "aware"; "awful"; "awkward";
    "back"; "bad"; "balanced"; "bare"; "basic"; "beautiful"; "beneficial";
    "better"; "bewildered"; "big"; "binding"; "biological"; "bitter"; "bizarre";
    "blank"; "blind"; "blonde"; "bloody"; "blushing"; "boiling"; "bold";
    "bored"; "boring"; "bottom"; "brainy"; "brave"; "breakable"; "breezy";
    "brief"; "bright"; "brilliant"; "broad"; "broken"; "bumpy"; "burning";
    "busy"; "calm"; "capable"; "capitalist"; "careful"; "casual"; "causal";
    "cautious"; "central"; "certain"; "changing"; "characteristic"; "charming";
    "cheap"; "cheerful"; "chemical"; "chief"; "chilly"; "chosen"; "christian";
    "chronic"; "chubby"; "circular"; "civic"; "civil"; "civilian"; "classic";
    "classical"; "clean"; "clear"; "clever"; "clinical"; "close"; "closed";
    "cloudy"; "clumsy"; "coastal"; "cognitive"; "coherent"; "cold"; "collective";
    "colonial"; "colorful"; "colossal"; "coloured"; "colourful"; "combative";
    "combined"; "comfortable"; "coming"; "commercial"; "common"; "communist";
    "compact"; "comparable"; "comparative"; "compatible"; "competent"; "competitive";
    "complete"; "complex"; "complicated"; "comprehensive"; "compulsory"; "conceptual";
    "concerned"; "concrete"; "condemned"; "confident"; "confidential"; "confused";
    "conscious"; "conservation"; "conservative"; "considerable"; "consistent"; 
    "constant"; "constitutional"; "contemporary"; "content"; "continental";
    "continued"; "continuing"; "continuous"; "controlled"; "controversial";
    "convenient"; "conventional"; "convincing"; "cooing"; "cool"; "cooperative"; "corporate"; "correct"; 
    "corresponding"; "costly"; "courageous"; "crazy"; "creative"; "creepy"; 
    "criminal"; "critical"; "crooked"; "crowded"; "crucial"; "crude"; "cruel";
    "cuddly"; "cultural"; "curious"; "curly"; "current"; "curved"; "cute";
    "daily"; "damaged"; "damp"; "dangerous"; "dark"; "dead"; "deaf"; "deafening";
    "dear"; "decent"; "decisive"; "deep"; "defeated"; "defensive"; "defiant";
    "definite"; "deliberate"; "delicate"; "delicious"; "delighted"; "delightful";
    "democratic"; "dependent"; "depressed"; "desirable"; "desperate"; "detailed";
    "determined"; "developed"; "developing"; "devoted"; "different"; "difficult";
    "digital"; "diplomatic"; "direct"; "dirty"; "disabled"; "disappointed";
    "disastrous"; "disciplinary"; "disgusted"; "distant"; "distinct"; "distinctive";
    "distinguished"; "disturbed"; "disturbing"; "diverse"; "divine"; "dizzy";
    "domestic"; "dominant"; "double"; "doubtful"; "drab"; "dramatic"; "dreadful";
    "driving"; "drunk"; "dry"; "dual"; "due"; "dull"; "dusty"; "dutch"; "dying";
    "dynamic"; "eager"; "early"; "eastern"; "easy"; "economic"; "educational";
    "eerie"; "effective"; "efficient"; "elaborate"; "elated"; "elderly"; "eldest";
    "electoral"; "electric"; "electrical"; "electronic"; "elegant"; "eligible";
    "embarrassed"; "embarrassing"; "emotional"; "empirical"; "empty"; "enchanting";
    "encouraging"; "endless"; "energetic"; "enormous"; "enthusiastic"; "entire";
    "entitled"; "envious"; "environmental"; "equal"; "equivalent"; "essential";
    "established"; "estimated"; "ethical"; "ethnic"; "eventual"; "everyday";
    "evident"; "evil"; "evolutionary"; "exact"; "excellent"; "exceptional";
    "excess"; "excessive"; "excited"; "exciting"; "exclusive"; "existing"; "exotic";
    "expected"; "expensive"; "experienced"; "experimental"; "explicit"; "extended";
    "extensive"; "external"; "extra"; "extraordinary"; "extreme"; "exuberant"; "faint";
    "fair"; "faithful"; "familiar"; "famous"; "fancy"; "fantastic"; "far"; "fascinating";
    "fashionable"; "fast"; "fat"; "fatal"; "favourable"; "favourite"; "federal"; "fellow";
    "female"; "feminist"; "few"; "fierce"; "filthy"; "final"; "financial"; "fine";
    "firm"; "fiscal"; "fit"; "fixed"; "flaky"; "flat"; "flexible"; "fluffy"; "fluttering";
    "flying"; "following"; "fond"; "foolish"; "foreign"; "formal"; "formidable";
    "forthcoming"; "fortunate"; "forward"; "fragile"; "frail"; "frantic"; "free";
    "frequent"; "fresh"; "friendly"; "frightened"; "front"; "frozen"; "full"; "fun";
    "functional"; "fundamental"; "funny"; "furious"; "future"; "fuzzy"; "gastric";
    "gay"; "general"; "generous"; "genetic"; "gentle"; "genuine"; "geographical";
    "giant"; "gigantic"; "given"; "glad"; "glamorous"; "gleaming"; "global";
    "glorious"; "golden"; "good"; "gorgeous"; "gothic"; "governing"; "graceful";
    "gradual"; "grand"; "grateful"; "greasy"; "great"; "grieving"; "grim"; "gross";
    "grotesque"; "growing"; "grubby"; "grumpy"; "guilty"; "handicapped"; "handsome";
    "happy"; "hard"; "harsh"; "head"; "healthy"; "heavy"; "helpful"; "helpless";
    "hidden"; "high"; "hilarious"; "hissing"; "historic"; "historical"; "hollow";
    "holy"; "homeless"; "homely"; "hon"; "honest"; "horizontal"; "horrible"; "hostile";
    "hot"; "huge"; "human"; "hungry"; "hurt"; "hushed"; "husky"; "icy"; "ideal";
    "identical"; "ideological"; "ill"; "illegal"; "imaginative"; "immediate"; 
    "immense"; "imperial"; "implicit"; "important"; "impossible"; "impressed";
    "impressive"; "improved"; "inadequate"; "inappropriate"; "inc"; "inclined";
    "increased"; "increasing"; "incredible"; "independent"; "indirect"; "individual";
    "industrial"; "inevitable"; "influential"; "informal"; "inherent"; "initial";
    "injured"; "inland"; "inner"; "innocent"; "innovative"; "inquisitive"; "instant";
    "institutional"; "insufficient"; "intact"; "integral"; "integrated"; "intellectual";
    "intelligent"; "intended"; "intense"; "intensive"; "interested"; "interesting";
    "interim"; "interior"; "intermediate"; "internal"; "international"; "intimate";
    "invisible"; "involved"; "irrelevant"; "islamic"; "isolated"; "itchy"; "japanese";
    "jealous"; "joint"; "jolly"; "journalistic"; "joyful"; "joyous"; "jubilant";
    "judicial"; "juicy"; "junior"; "just"; "keen"; "key"; "kind"; "known"; "large";
    "large-scale"; "last"; "late"; "latent"; "later"; "latest"; "latter"; "lazy";
    "leading"; "left"; "legal"; "legislative"; "legitimate"; "lengthy"; "less";
    "lesser"; "level"; "lexical"; "liable"; "liberal"; "light"; "like"; "likely";
    "limited"; "linear"; "linguistic"; "liquid"; "literary"; "little"; "live";
    "lively"; "living"; "local"; "logical"; "lonely"; "long"; "long-term"; "loose";
    "lost"; "loud"; "lovely"; "low"; "loyal"; "lucky"; "mad"; "magenta"; "magic";
    "magnetic"; "magnificent"; "main"; "mainstream"; "major"; "male"; "mammoth";
    "managerial"; "managing"; "manual"; "many"; "marginal"; "marine"; "marked";
    "married"; "marvellous"; "marxist"; "mass"; "massive"; "mathematical"; "mature";
    "maximum"; "mean"; "meaningful"; "mechanical"; "medical"; "medieval"; "medium";
    "medium-term"; "mellow"; "melodic"; "melted"; "mental"; "mere"; "metropolitan";
    "mid"; "middle"; "middle-class"; "midterm"; "mighty"; "mild"; "military"; "miniature";
    "minimal"; "minimum"; "ministerial"; "minor"; "miserable"; "misleading"; "missing";
    "misty"; "mixed"; "moaning"; "mobile"; "moderate"; "modern"; "modest"; "moist";
    "molecular"; "monetary"; "monthly"; "moral"; "motionless"; "muddy"; "multiple";
    "mushy"; "musical"; "mute"; "mutual"; "mysterious"; "naked"; "narrow"; "nasty";
    "national"; "native"; "natural"; "naughty"; "naval"; "near"; "nearby"; "neat";
    "necessary"; "negative"; "neighbouring"; "nervous"; "net"; "neutral"; "new";
    "next"; "nice"; "noble"; "noisy"; "normal"; "northern"; "nosy"; "notable";
    "noticeable"; "novel"; "nuclear"; "numerous"; "nursing"; "nutty"; "obedient";
    "objective"; "obliged"; "obnoxious"; "obvious"; "occasional"; "occupational";
    "odd"; "offensive"; "official"; "ok"; "old"; "old-fashioned"; "olympic"; "only";
    "open"; "operational"; "opposite"; "optimistic"; "oral"; "orange"; "ordinary";
    "organic"; "organisational"; "original"; "orthodox"; "other"; "outer"; "outdoor";
    "outermost"; "outgoing"; "outstanding"; "overall"; "overseas"; "overwhelming";
    "painful"; "pale"; "parallel"; "parental"; "parliamentary"; "particular";
    "passing"; "passive"; "past"; "patient"; "peaceful"; "peculiar"; "perfect";
    "permanent"; "persistent"; "personal"; "pertinent"; "pessimistic"; "petite";
    "philosophical"; "physical"; "pink"; "plain"; "planned"; "plastic"; "pleasant";
    "pleased"; "poised"; "polished"; "polite"; "political"; "poor"; "popular";
    "positive"; "possible"; "potential"; "powerful"; "practical"; "precious";
    "precise"; "predictable"; "preferred"; "pregnant"; "preliminary"; "premature";
    "premier"; "prepared"; "present"; "presidential"; "pretty"; "previous"; "primary";
    "prime"; "primitive"; "principal"; "printed"; "prior"; "private"; "privileged";
    "pro"; "probable"; "productive"; "prof"; "professional"; "profitable"; "profound";
    "progressive"; "prolonged"; "prominent"; "promising"; "proper"; "proposed";
    "prospective"; "protective"; "proud"; "provincial"; "public"; "pumped"; "puny";
    "pure"; "purple"; "puzzled"; "puzzling"; "qualitative"; "quantitative";
    "quick"; "quiet"; "racial"; "radical"; "rainy"; "random"; "rapid"; "rare";
    "rational"; "raw"; "ready"; "real"; "realistic"; "rear"; "reasonable"; "recent";
    "reckless"; "recognisable"; "recognized"; "red"; "reduced"; "redundant"; "regardless";
    "regional"; "registered"; "regular"; "regulatory"; "related"; "relative";
    "relaxed"; "relevant"; "reliable"; "relieved"; "religious"; "reluctant";
    "remarkable"; "remote"; "renewable"; "representative"; "reproductive"; "required";
    "resident"; "residential"; "respective"; "responsible"; "retail"; "retired";
    "revolutionary"; "rich"; "ridiculous"; "right"; "rigid"; "ripe"; "rising"; "risky";
    "ritualistic"; "roasted"; "robust"; "romantic"; "rotten"; "rough"; "round";
    "royal"; "rubbery"; "rude"; "ruling"; "running"; "rural"; "sacred"; "sad"; "safe";
    "salty"; "same"; "satisfactory"; "satisfied"; "scared"; "scary"; "scheduled";
    "scholarly"; "scientific"; "scornful"; "scrawny"; "screeching"; "scruffy"; "secret";
    "secure"; "select"; "selected"; "selective"; "selfish"; "semantic"; "senior";
    "sensible"; "sensitive"; "separate"; "serious"; "serene"; "several"; "severe";
    "sexual"; "shaggy"; "shaky"; "shallow"; "shared"; "sharp"; "sheer"; "shiny";
    "shivering"; "shocked"; "shocking"; "short"; "short-term"; "shrill"; "shy";
    "sick"; "significant"; "silent"; "silky"; "silly"; "silver"; "similar"; "simple";
    "single"; "sizzling"; "skilled"; "skinny"; "sleepy"; "slight"; "slim"; "slimy";
    "slippery"; "sloppy"; "slow"; "small"; "smart"; "smelly"; "smiling"; "smoggy";
    "smooth"; "social"; "soft"; "soggy"; "solar"; "sole"; "solid"; "sophisticated";
    "sore"; "sorry"; "sound"; "sour"; "southern"; "sovereign"; "spare"; "sparkling";
    "spatial"; "special"; "specific"; "spectacular"; "spicy"; "spiritual"; "splendid";
    "spontaneous"; "sporting"; "spotless"; "spotty"; "square"; "squealing"; "squeamish";
    "stable"; "stale"; "standard"; "static"; "statistical"; "steady"; "steep";
    "stereotypical"; "stern"; "sticky"; "stiff"; "still"; "stingy"; "stormy";
    "straight"; "straightforward"; "strange"; "strategic"; "strict"; "striking";
    "strong"; "structural"; "stubborn"; "stunning"; "stupid"; "stylish"; "subjective";
    "subsequent"; "substantial"; "subtle"; "successful"; "successive"; "sudden";
    "sufficient"; "sugary"; "suitable"; "sunny"; "super"; "superb"; "superior";
    "supportive"; "supposed"; "supreme"; "sure"; "surprised"; "surprising"; "suspicious";
    "swanky"; "sweaty"; "sweet"; "swift"; "sympathetic"; "systematic"; "tall";
    "tame"; "tan"; "tangible"; "tart"; "tasty"; "tattered"; "taut"; "tearful";
    "technical"; "temporary"; "tempting"; "tender"; "tense"; "terrible"; "terrific";
    "terrified"; "terrifying"; "testy"; "thankful"; "theoretical"; "thick"; "thin";
    "thinkable"; "third"; "thirsty"; "thorough"; "thoughtful"; "thoughtless";
    "threatening"; "thrilled"; "thrilling"; "thundering"; "tidy"; "tight"; "tiny";
    "tired"; "top"; "torn"; "total"; "tough"; "traditional"; "tragical"; "tranquil";
    "transitional"; "transparent"; "treasured"; "tremendous"; "tricky"; "triple";
    "trivial"; "troubled"; "true"; "turkey"; "twinkling"; "two"; "ugly"; "ultimate";
    "unacceptable"; "unaware"; "uncertain"; "unchanged"; "uncomfortable"; "unconscious";
    "underground"; "underlying"; "unemployed"; "unequal"; "uneven"; "unexpected";
    "unfair"; "unfortunate"; "unhappy"; "uniform"; "uninterested"; "unique"; "unknown";
    "unlikely"; "unpleasant"; "unsightly"; "unsuitable"; "untidy"; "unwilling";
    "upcoming"; "upper"; "upset"; "upstairs"; "urban"; "urgent"; "used"; "useful";
    "useless"; "usual"; "vague"; "vain"; "valid"; "valuable"; "variable"; "varied";
    "various"; "vast"; "verbal"; "vertical"; "very"; "victorious"; "video"; "violent";
    "virtual"; "visible"; "visual"; "vital"; "vivacious"; "vivid"; "vocal"; "vogue";
    "volatile"; "voluntary"; "vulnerable"; "warm"; "wary"; "wasteful"; "watchful";
    "waterlogged"; "watery"; "weak"; "wealthy"; "weary"; "wee"; "weekly"; "weird";
    "wet"; "whispering"; "white"; "whole"; "wholesome"; "wicked"; "wide"; "widespread";
    "wild"; "willing"; "windy"; "wired"; "wiry"; "wise"; "wistful"; "witty"; "wobbly";
    "woeful"; "wonderful"; "wooden"; "woozy"; "worn"; "worried"; "worse"; "worst";
    "worthwhile"; "worthy"; "wounded"; "written"; "wrong"; "wry"; "yellow"; "young";
    "yummy"; "zany"; "zealous"; "zesty"; "zippy"; "zonked" 
|]

let chooseOne<'a> (units: 'a seq) =
    Seq.item 
    <| random 0 (Seq.length units) 
    <| units

let chooseDescription () =
    chooseOne<string> adjectives

let chooseAnimal () =
    chooseOne<string> animals

printfn "%s_%s"
<| chooseDescription ()
<| chooseAnimal ()