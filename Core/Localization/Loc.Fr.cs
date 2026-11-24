namespace NtfyDesktop;

// French translations. Key = the English source string exactly as it appears in XAML / code.
// Index-initializer syntax on purpose: a duplicate key overwrites instead of throwing at startup.
public static partial class Loc
{
    private static readonly Dictionary<string, string> Fr = new()
    {
        // ---- Buttons / commands ----
        ["Access token"] = "Jeton d'accès",
        ["Add rule ▾"] = "Ajouter une règle ▾",
        ["Add server"] = "Ajouter un serveur",
        ["Edit server"] = "Modifier le serveur",
        ["Add topic"] = "Ajouter un sujet",
        ["All topics"] = "Tous les sujets",
        ["All"] = "Tous",
        ["Apply to history"] = "Appliquer à l'historique",
        ["Apply"] = "Appliquer",
        ["Applied"] = "Appliqué",
        ["Cancel"] = "Annuler",
        ["Check for updates"] = "Rechercher des mises à jour",
        ["Clear"] = "Effacer",
        ["Close"] = "Fermer",
        ["Connections"] = "Connexions",
        ["Delete rule"] = "Supprimer la règle",
        ["Delete"] = "Supprimer",
        ["Deselect all"] = "Tout désélectionner",
        ["Discard"] = "Abandonner",
        ["Disconnect all"] = "Tout déconnecter",
        ["Draft with AI…"] = "Rédiger avec l'IA…",
        ["Edit"] = "Modifier",
        ["Enabled (subscribe to this topic)"] = "Activé (s'abonner à ce sujet)",
        ["Generate"] = "Générer",
        ["Height"] = "Hauteur",
        ["Manage rule packs…"] = "Gérer les packs de règles…",
        ["New"] = "Nouveau",
        ["Notify on recovery"] = "Notifier au rétablissement",
        ["Only notify during active hours"] = "Notifier uniquement pendant les heures actives",
        ["Override active hours"] = "Remplacer les heures actives",
        ["Override minimum priority"] = "Remplacer la priorité minimale",
        ["Pause notifications for this topic"] = "Suspendre les notifications de ce sujet",
        ["Pause notifications"] = "Suspendre les notifications",
        ["Pick…"] = "Choisir…",
        ["Preview…"] = "Aperçu…",
        ["Preview"] = "Aperçu",
        ["Reconnect all"] = "Tout reconnecter",
        ["Reconnect"] = "Reconnecter",
        ["Refresh"] = "Actualiser",
        ["Remove"] = "Retirer",
        ["Reset catch-up (dev)"] = "Réinitialiser le rattrapage (dev)",
        ["Resume notifications"] = "Reprendre les notifications",
        ["Save pack"] = "Enregistrer le pack",
        ["Save"] = "Enregistrer",
        ["Select all"] = "Tout sélectionner",
        ["Set default"] = "Définir par défaut",
        ["Show suppressed"] = "Afficher les masqués",
        ["Suppress toast (and hide from feed)"] = "Supprimer la notification (et masquer du flux)",
        ["Use this message"] = "Utiliser ce message",
        ["Username & password"] = "Nom d'utilisateur et mot de passe",
        ["← Back"] = "← Retour",
        ["OK"] = "OK",
        ["Send"] = "Envoyer",
        ["Keep history"] = "Conserver l'historique",
        ["Delete history"] = "Supprimer l'historique",
        ["Open Settings"] = "Ouvrir les paramètres",
        ["Restart & update"] = "Redémarrer et mettre à jour",
        ["Updating…"] = "Mise à jour…",

        // ---- Menu headers (rules + context menus) ----
        ["Blank correlate rule"] = "Règle de corrélation vide",
        ["Blank expect rule"] = "Règle d'attente vide",
        ["Blank match rule"] = "Règle de correspondance vide",
        ["Heartbeat (alert if it stops)"] = "Signal de vie (alerte s'il s'arrête)",
        ["Pair problem ↔ resolved"] = "Associer problème ↔ résolu",
        ["Suppress noisy successes"] = "Masquer les succès bruyants",
        ["Hide routine “success/OK” messages (no toast, hidden from feed)."] =
            "Masque les messages de routine « succès/OK » (pas de notification, masqués du flux).",
        ["Fold a PROBLEM and its matching RESOLVED out of the feed once paired."] =
            "Retire du flux un PROBLÈME et son RÉSOLU correspondant une fois associés.",
        ["Alert when an expected recurring message stops arriving."] =
            "Alerte quand un message récurrent attendu n'arrive plus.",
        ["Heartbeat missed"] = "Signal de vie manqué",
        ["Mark all read"] = "Tout marquer comme lu",
        ["Mark as read"] = "Marquer comme lu",
        ["Disable"] = "Désactiver",
        ["Enable"] = "Activer",
        ["Draft rules from this topic…"] = "Rédiger des règles à partir de ce sujet…",
        ["Move up"] = "Monter",
        ["Move down"] = "Descendre",
        ["Move to group"] = "Déplacer vers le groupe",
        ["Ungrouped"] = "Sans groupe",

        // ---- Placeholders ----
        ["Friendly label shown in the sidebar"] = "Nom affiché dans la barre latérale",
        ["Pack name"] = "Nom du pack",
        ["Search title, body, tags"] = "Rechercher dans le titre, le texte, les étiquettes",
        ["Username"] = "Nom d'utilisateur",
        ["e.g. Event ID:"] = "ex. ID d'événement :",
        ["e.g. Home, ntfy.sh"] = "ex. Maison, ntfy.sh",
        ["e.g. alerts-prod"] = "ex. alertes-prod",
        ["e.g. backup successes are noise unless they stop; pair problem/resolved by event id"] =
            "ex. les succès de sauvegarde sont du bruit sauf s'ils s'arrêtent ; associer problème/résolu par ID d'événement",

        // ---- Labels / text ----
        ["AI provider"] = "Fournisseur d'IA",
        ["API key"] = "Clé API",
        ["Active hours"] = "Heures actives",
        ["Add tag"] = "Ajouter une étiquette",
        ["Appearance"] = "Apparence",
        ["At least every"] = "Au moins toutes les",
        ["Attachment cache limit"] = "Limite du cache des pièces jointes",
        ["Attachments"] = "Pièces jointes",
        ["Authentication"] = "Authentification",
        ["Body"] = "Corps",
        ["Browse, create, edit, enable/disable, preview and apply rule packs — or draft one with AI."] =
            "Parcourez, créez, modifiez, activez/désactivez, prévisualisez et appliquez des packs de règles — ou rédigez-en un avec l'IA.",
        ["Cache each message's attachment as soon as it arrives, so it survives the server's short expiry. When off, attachments download on demand (files when opened, images when their feed is viewed)."] =
            "Met en cache la pièce jointe de chaque message dès son arrivée, pour qu'elle survive à la courte expiration du serveur. Désactivé, les pièces jointes se téléchargent à la demande (fichiers à l'ouverture, images à l'affichage du flux).",
        ["Check GitHub for a new release on startup and once a day, and show a banner and a notification when one is available. Updates only download when you choose to install them."] =
            "Recherche une nouvelle version sur GitHub au démarrage puis une fois par jour, et affiche une bannière et une notification si elle existe. Les mises à jour ne sont téléchargées que si vous choisissez de les installer.",
        ["Check for updates automatically"] = "Rechercher les mises à jour automatiquement",
        ["Check now"] = "Rechercher maintenant",
        ["Close (resolved) matches"] = "Correspondances de fermeture (résolu)",
        ["Connections remain active and messages are still recorded — only toasts are suppressed."] =
            "Les connexions restent actives et les messages sont toujours enregistrés — seules les notifications sont supprimées.",
        ["Correlation key"] = "Clé de corrélation",
        ["Default"] = "Par défaut",
        ["Defaults"] = "Valeurs par défaut",
        ["Display name (optional)"] = "Nom affiché (facultatif)",
        ["Do"] = "Faire",
        ["Download attachments on arrival"] = "Télécharger les pièces jointes à l'arrivée",
        ["Drop messages below this priority. Per-topic overrides take precedence."] =
            "Ignore les messages sous cette priorité. Les réglages propres à un sujet sont prioritaires.",
        ["Enable rule engine"] = "Activer le moteur de règles",
        ["Enabled"] = "Activé",
        ["End (HH:mm)"] = "Fin (HH:mm)",
        ["Endpoint base URL"] = "URL de base du point d'accès",
        ["Expect a message matching"] = "Attendre un message correspondant à",
        ["Fetched live from the provider — click Refresh after entering your key. You can also type a model id."] =
            "Récupéré en direct chez le fournisseur — cliquez sur Actualiser après avoir saisi votre clé. Vous pouvez aussi saisir un identifiant de modèle.",
        ["Find it in the"] = "Trouvez-la dans la",
        ["Grace"] = "Délai de grâce",
        ["Group (optional)"] = "Groupe (facultatif)",
        ["Heartbeat gaps that would alert"] = "Absences de signal qui déclencheraient une alerte",
        ["History retention"] = "Conservation de l'historique",
        ["Intent (optional)"] = "Intention (facultatif)",
        ["Key regex — capture (?<key>…) the shared id"] = "Regex de la clé — capturez (?<key>…) l'ID commun",
        ["Larger attachments aren't fetched automatically, but you can still open them on demand."] =
            "Les pièces jointes plus grandes ne sont pas récupérées automatiquement, mais vous pouvez toujours les ouvrir à la demande.",
        ["Launch this app at sign-in (minimised to tray)."] =
            "Lancer cette application à l'ouverture de session (réduite dans la zone de notification).",
        ["Live connection status for each subscribed topic."] =
            "État de connexion en direct de chaque sujet suivi.",
        ["MB"] = "Mo",
        ["Master switch for noise suppression, problem/resolved folding, and heartbeat alerts. When off, every message passes through unchanged."] =
            "Interrupteur général de la suppression du bruit, du regroupement problème/résolu et des alertes de signal de vie. Désactivé, chaque message passe sans modification.",
        ["Max size to auto-download"] = "Taille max. du téléchargement automatique",
        ["Message (optional)"] = "Message (facultatif)",
        ["Min priority"] = "Priorité min.",
        ["Minimum priority (global)"] = "Priorité minimale (globale)",
        ["Model"] = "Modèle",
        ["Name"] = "Nom",
        ["No messages in this scope would be affected by this pack."] =
            "Aucun message de cette portée ne serait affecté par ce pack.",
        ["No notifications"] = "Aucune notification",
        ["No topics configured"] = "Aucun sujet configuré",
        ["Nothing here yet. Messages arrive in real time once topics start sending."] =
            "Rien pour l'instant. Les messages arrivent en temps réel dès que les sujets envoient quelque chose.",
        ["Notification rules"] = "Règles de notification",
        ["Notifications are paused"] = "Les notifications sont suspendues",
        ["Older messages are pruned by the background sweep."] =
            "Les anciens messages sont supprimés par le nettoyage en arrière-plan.",
        ["On absence — alert"] = "En cas d'absence — alerter",
        ["Open (problem) matches"] = "Correspondances d'ouverture (problème)",
        ["OpenAI-compatible base URL (e.g. https://api.openai.com/v1)."] =
            "URL de base compatible OpenAI (ex. https://api.openai.com/v1).",
        ["Optional bearer token for authenticated topics."] =
            "Jeton « bearer » facultatif pour les sujets authentifiés.",
        ["Or paste messages (one per line)"] = "Ou collez des messages (un par ligne)",
        ["Outside this window messages are still recorded but no toast is shown."] =
            "En dehors de cette plage, les messages sont enregistrés mais aucune notification n'est affichée.",
        ["Pack JSON (editable)"] = "JSON du pack (modifiable)",
        ["Packs"] = "Packs",
        ["Pick a message that should match. Its text fills the field (as 'Contains'); tweak afterwards."] =
            "Choisissez un message qui doit correspondre. Son texte remplit le champ (comme « Contient ») ; ajustez ensuite.",
        ["Pick representative messages. The AI uses these (and your intent) to draft rules."] =
            "Choisissez des messages représentatifs. L'IA les utilise (avec votre intention) pour rédiger des règles.",
        ["Priority"] = "Priorité",
        ["Proposed rules"] = "Règles proposées",
        ["Recovery priority"] = "Priorité de rétablissement",
        ["Recovery title"] = "Titre de rétablissement",
        ["Rule packs"] = "Packs de règles",
        ["Rules"] = "Règles",
        ["Sample messages"] = "Messages d'exemple",
        ["Select a pack on the left, or create one."] = "Sélectionnez un pack à gauche, ou créez-en un.",
        ["Server URL"] = "URL du serveur",
        ["Server"] = "Serveur",
        ["Server, defaults, and topic subscriptions."] = "Serveur, valeurs par défaut et abonnements aux sujets.",
        ["Servers"] = "Serveurs",
        ["Settings"] = "Paramètres",
        ["Show server labels in sidebar"] = "Afficher le nom du serveur dans la barre latérale",
        ["Show which server each topic belongs to, as a subtitle under its name. Only visible with more than one server."] =
            "Affiche le serveur de chaque sujet en sous-titre sous son nom. Visible uniquement avec plusieurs serveurs.",
        ["Show"] = "Afficher",
        ["Start (HH:mm)"] = "Début (HH:mm)",
        ["Start with Windows"] = "Démarrer avec Windows",
        ["Stored encrypted on this machine (DPAPI), like the access token. Sent only to the endpoint above."] =
            "Stocké chiffré sur cet ordinateur (DPAPI), comme le jeton d'accès. Envoyé uniquement au point d'accès ci-dessus.",
        ["System"] = "Système",
        ["Tag"] = "Étiquette",
        ["Test against"] = "Tester sur",
        ["Text just before the id (optional)"] = "Texte juste avant l'ID (facultatif)",
        ["The id is a"] = "L'ID est un",
        ["The shared id that ties a problem to its resolution (e.g. an event id present in both)."] =
            "L'ID commun qui relie un problème à sa résolution (ex. un ID d'événement présent dans les deux).",
        ["Title"] = "Titre",
        ["Topic"] = "Sujet",
        ["Total disk budget for cached attachments (auto-downloaded and opened). The least-recently-used files are removed when the limit is exceeded."] =
            "Espace disque total pour les pièces jointes en cache (téléchargées automatiquement et ouvertes). Les fichiers les moins récemment utilisés sont supprimés quand la limite est dépassée.",
        ["Update channel"] = "Canal de mise à jour",
        ["Updates"] = "Mises à jour",
        ["Use the ‘Add topic’ entry in the sidebar to start receiving notifications."] =
            "Utilisez l'entrée « Ajouter un sujet » de la barre latérale pour commencer à recevoir des notifications.",
        ["Used to draft rule packs from sample messages. Pick a preset or Custom; presets live in an editable providers.json in the app data folder."] =
            "Sert à rédiger des packs de règles à partir de messages d'exemple. Choisissez un préréglage ou Personnalisé ; les préréglages se trouvent dans un fichier providers.json modifiable, dans le dossier de données de l'application.",
        ["When a message matches"] = "Quand un message correspond à",
        ["Window"] = "Fenêtre",
        ["Wraps past midnight when end < start (e.g. 22:00 → 06:00)."] =
            "Passe minuit quand la fin est avant le début (ex. 22:00 → 06:00).",
        ["days"] = "jours",
        ["messages"] = "messages",
        ["ntfy servers you subscribe to. Each topic belongs to one server; new topics use the default."] =
            "Serveurs ntfy auxquels vous êtes abonné. Chaque sujet appartient à un serveur ; les nouveaux sujets utilisent celui par défaut.",
        ["to"] = "à",
        ["using"] = "avec",
        ["• Unsaved changes"] = "• Modifications non enregistrées",
        ["⚠ This server uses plain HTTP. Credentials will not be sent — switch to HTTPS for authentication."] =
            "⚠ Ce serveur utilise HTTP simple. Les identifiants ne seront pas envoyés — passez en HTTPS pour vous authentifier.",
        ["Custom"] = "Personnalisé",

        // ---- Window titles ----
        ["Draft rules with AI"] = "Rédiger des règles avec l'IA",
        ["Feed"] = "Flux",
        ["Manage rule packs"] = "Gérer les packs de règles",
        ["Pick a sample message"] = "Choisir un message d'exemple",

        // ---- Tooltips ----
        ["Delete this message"] = "Supprimer ce message",
        ["Fill from a sample message"] = "Remplir à partir d'un message d'exemple",
        ["Open attachment"] = "Ouvrir la pièce jointe",
        ["Open image"] = "Ouvrir l'image",
        ["Open link"] = "Ouvrir le lien",
        ["Save changes and close"] = "Enregistrer et fermer",
        ["Save changes and keep this window open"] = "Enregistrer et garder cette fenêtre ouverte",

        // ---- Priorities ----
        ["Min"] = "Min",
        ["Low"] = "Basse",
        ["High"] = "Haute",
        ["Urgent"] = "Urgente",

        // ---- Status / connection ----
        ["Connecting…"] = "Connexion…",
        ["Connected"] = "Connecté",
        ["Reconnecting…"] = "Reconnexion…",
        ["Disconnected"] = "Déconnecté",
        ["Checking…"] = "Vérification…",
        ["Match"] = "Correspondance",
        ["Correlate"] = "Corrélation",
        ["Expect"] = "Attente",

        // ---- Update banner / settings messages ----
        ["An update is available"] = "Une mise à jour est disponible",
        ["Version {0} is available"] = "La version {0} est disponible",
        ["Downloading… {0}%"] = "Téléchargement… {0} %",
        ["The update downloads in the background, then the app restarts to finish."] =
            "La mise à jour se télécharge en arrière-plan, puis l'application redémarre pour terminer.",
        ["You're running version {0}."] = "Vous utilisez la version {0}.",
        ["Switch to {0} channel"] = "Passer au canal {0}",
        ["Switch to {0}"] = "Passer à {0}",
        ["Stay on {0}"] = "Rester sur {0}",
        ["Switching to the {0} channel — use the update banner to apply it, or revert below."] =
            "Passage au canal {0} — utilisez la bannière de mise à jour pour l'appliquer, ou annulez ci-dessous.",
        ["You're on the dev channel — new features land here first, but builds may be less stable."] =
            "Vous êtes sur le canal dev — les nouveautés arrivent ici en premier, mais les versions peuvent être moins stables.",
        ["You're on the stable channel. Switch to dev to get new features early (they may be less stable)."] =
            "Vous êtes sur le canal stable. Passez en dev pour obtenir les nouveautés plus tôt (elles peuvent être moins stables).",
        ["Version {0} is available — use the banner to install it."] =
            "La version {0} est disponible — utilisez la bannière pour l'installer.",
        ["You're on the latest version."] = "Vous avez la dernière version.",
        ["Couldn't check for updates. Please try again later."] =
            "Impossible de rechercher des mises à jour. Réessayez plus tard.",
        ["Automatic updates aren't available in this build."] =
            "Les mises à jour automatiques ne sont pas disponibles dans cette version.",
        ["Version {0} is available on the {1} channel — use the banner to install it."] =
            "La version {0} est disponible sur le canal {1} — utilisez la bannière pour l'installer.",
        ["You're on the latest {0} version."] = "Vous avez la dernière version du canal {0}.",
        ["Dev builds get new features early but can be less stable. You'll get the latest dev build the next time you update.\n\nSwitch to the dev channel?"] =
            "Les versions dev reçoivent les nouveautés plus tôt mais peuvent être moins stables. Vous obtiendrez la dernière version dev à la prochaine mise à jour.\n\nPasser au canal dev ?",
        ["The stable channel may be an earlier version than your current dev build, so the next update can move you to an older but more stable release.\n\nSwitch to the stable channel?"] =
            "Le canal stable peut être en retard sur votre version dev actuelle : la prochaine mise à jour peut donc vous ramener à une version plus ancienne mais plus stable.\n\nPasser au canal stable ?",

        // ---- Toasts (app) ----
        ["Update available"] = "Mise à jour disponible",
        ["A new version is ready. Open ntfy Desktop to install it."] =
            "Une nouvelle version est prête. Ouvrez ntfy Desktop pour l'installer.",
        ["Version {0} is ready. Open ntfy Desktop to install it."] =
            "La version {0} est prête. Ouvrez ntfy Desktop pour l'installer.",
        ["You're up to date"] = "Vous êtes à jour",
        ["ntfy Desktop is running the latest version."] = "ntfy Desktop est à jour.",
        ["Couldn't check for updates"] = "Impossible de rechercher des mises à jour",
        ["Please try again later."] = "Réessayez plus tard.",

        // ---- Dialogs ----
        ["Remove server"] = "Retirer le serveur",
        ["You must keep at least one server."] = "Vous devez conserver au moins un serveur.",
        ["Remove “{0}” and its {1} topic(s)?\n\nKeep their message history (still browsable under “All topics”), or delete it too?"] =
            "Retirer « {0} » et ses {1} sujet(s) ?\n\nConserver leur historique de messages (consultable sous « Tous les sujets ») ou le supprimer aussi ?",
        ["Remove “{0}”?"] = "Retirer « {0} » ?",
        ["Remove topic"] = "Retirer le sujet",
        ["Remove “{0}”?\n\nKeep its message history (still browsable under “All topics”), or delete it too?"] =
            "Retirer « {0} » ?\n\nConserver son historique de messages (consultable sous « Tous les sujets ») ou le supprimer aussi ?",
        ["Server not configured"] = "Serveur non configuré",
        ["Set a valid server URL in Settings before adding topics."] =
            "Saisissez une URL de serveur valide dans les paramètres avant d'ajouter des sujets.",
        ["Unsaved changes"] = "Modifications non enregistrées",
        ["You have unsaved changes in Settings. Save them, discard them, or stay on the page?"] =
            "Vous avez des modifications non enregistrées dans les paramètres. Les enregistrer, les abandonner ou rester sur la page ?",
        ["Notifications are paused globally — use the title-bar Resume button."] =
            "Les notifications sont suspendues globalement — utilisez le bouton Reprendre de la barre de titre.",
        ["Run action?"] = "Exécuter l'action ?",
        ["This will send a request:\n\n{0} {1}\n\nProceed?"] =
            "Une requête va être envoyée :\n\n{0} {1}\n\nContinuer ?",
        ["Action failed"] = "L'action a échoué",
        ["The request could not be sent:\n\n{0}"] = "La requête n'a pas pu être envoyée :\n\n{0}",
        ["Unexpected error: "] = "Erreur inattendue : ",
        ["Validation"] = "Validation",
        ["Server URL is required."] = "L'URL du serveur est obligatoire.",
        ["Not a valid URL."] = "URL non valide.",
        ["No stored messages to pick from for this topic yet."] =
            "Aucun message enregistré à choisir pour ce sujet pour l'instant.",
        ["Select at least one sample message (or paste some)."] =
            "Sélectionnez au moins un message d'exemple (ou collez-en).",
        ["Couldn't draft a pack."] = "Impossible de rédiger un pack.",
        ["Nothing to save — generate a pack first."] = "Rien à enregistrer — générez d'abord un pack.",
        ["The pack needs a name."] = "Le pack doit avoir un nom.",
        ["An expect rule needs an absence-alert title."] =
            "Une règle d'attente a besoin d'un titre d'alerte d'absence.",
        ["New pack"] = "Nouveau pack",
        ["Match rule"] = "Règle de correspondance",
        ["Correlate rule"] = "Règle de corrélation",
        ["Expect rule"] = "Règle d'attente",
        ["All changes saved ({0} pack(s))."] = "Toutes les modifications sont enregistrées ({0} pack(s)).",
        ["Apply to history"] = "Appliquer à l'historique",
        ["This can’t be automatically undone. Apply?"] = "Cela ne peut pas être annulé automatiquement. Appliquer ?",

        // ---- Feed header ----
        ["Messages from every subscribed topic."] = "Messages de tous les sujets suivis.",
        ["Messages from {0}."] = "Messages de {0}.",
        ["this topic"] = "ce sujet",

        // ---- Rule preview ----
        ["Tested against {0} stored message(s) — {1}."] = "Testé sur {0} message(s) enregistré(s) — {1}.",
        ["Folds (resolved)"] = "Regroupé (résolu)",
        ["Hidden"] = "Masqué",
        ["Opens incident"] = "Ouvre un incident",
        ["Tagged: "] = "Étiquettes : ",

        // ---- Notification actions ----
        ["Broadcast actions are Android-only."] = "Les actions de diffusion ne fonctionnent que sur Android.",
        ["This action has no valid http(s) URL."] = "Cette action n'a pas d'URL http(s) valide.",
        ["This action has nothing to copy."] = "Cette action n'a rien à copier.",
        ["This action type isn't supported."] = "Ce type d'action n'est pas pris en charge.",

        // ---- Toasts (messages) ----
        ["{0} message while you were away"] = "{0} message pendant votre absence",
        ["{0} messages while you were away"] = "{0} messages pendant votre absence",
        ["in {0}"] = "dans {0}",
        [", +{0} more"] = ", +{0} autres",
        ["Open"] = "Ouvrir",
        ["🔴 Urgent · {0}"] = "🔴 Urgente · {0}",
        ["🟠 High · {0}"] = "🟠 Haute · {0}",
        ["🔵 Low · {0}"] = "🔵 Basse · {0}",
        ["⚪ Min · {0}"] = "⚪ Min · {0}",
        ["Show"] = "Afficher",

        // ---- Tray ----
        ["connected"] = "connecté",
        ["reconnecting"] = "reconnexion",
        ["disconnected"] = "déconnecté",
        [", {0} unread"] = ", {0} non lu(s)",
        [", notifications paused"] = ", notifications suspendues",

        // ---- Relative time ----
        ["just now"] = "à l'instant",
        ["{0}m ago"] = "il y a {0} min",
        ["{0}h ago"] = "il y a {0} h",
        ["yesterday"] = "hier",
        ["{0}d ago"] = "il y a {0} j",
    };
}
