using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram_Bot
{
    class Program
    {
        private static string Token { get; set; } = "2114836077:AAG1ajQPHCX4lLjGbEJz-ShdzuOretioVeM";
        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient(Token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
           
        }
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                Console.WriteLine($"Пришло сообщение с текстом: {msg.Text}");
                Random rnd = new Random();
                switch (msg.Text)
                {
                    case "Sticker":

                        switch (rnd.Next(1, 30))
                        {
                            case 1:
                                Message message1 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/1.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 2:
                                Message message2 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/2.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 3:
                                Message message3 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/4.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 4:
                                Message message4 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/6.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 5:
                                Message message5 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/8.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 6:
                                Message message6 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/12.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 7:
                                Message message7 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/21.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 8:
                                Message message8 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/23.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 9:
                                Message message9 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/35.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 10:
                                Message message10 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/47.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 11:
                                Message message11 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/40.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 12:
                                Message message12 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/30.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 13:
                                Message message13 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/27.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 14:
                                Message message14 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/39.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 15:
                                Message message15 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/60.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 16:
                                Message message16 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/b53/a2e/b53a2e79-4354-32aa-80bf-439e203de491/192/2.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 17:
                                Message message17 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/b53/a2e/b53a2e79-4354-32aa-80bf-439e203de491/192/10.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 18:
                                Message message18 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/b53/a2e/b53a2e79-4354-32aa-80bf-439e203de491/192/9.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 19:
                                Message message19 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/b53/a2e/b53a2e79-4354-32aa-80bf-439e203de491/192/32.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 20:
                                Message message20 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/b53/a2e/b53a2e79-4354-32aa-80bf-439e203de491/192/53.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 21:
                                Message message21 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/697/ba1/697ba160-9c77-3b1a-9d97-86a9ce75ff4d/192/35.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 22:
                                Message message22 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/697/ba1/697ba160-9c77-3b1a-9d97-86a9ce75ff4d/192/74.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 23:
                                Message message23 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/697/ba1/697ba160-9c77-3b1a-9d97-86a9ce75ff4d/192/112.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 24:
                                Message message24 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/697/ba1/697ba160-9c77-3b1a-9d97-86a9ce75ff4d/192/112.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 25:
                                Message message25 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/697/ba1/697ba160-9c77-3b1a-9d97-86a9ce75ff4d/192/8.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 26:
                                Message message26 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/345/7c2/3457c236-4b9c-3e7c-aa95-939ffbd6781a/192/5.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 27:
                                Message message27 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/345/7c2/3457c236-4b9c-3e7c-aa95-939ffbd6781a/192/1.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 28:
                                Message message28 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://cdn.tlgrm.app/stickers/345/7c2/3457c236-4b9c-3e7c-aa95-939ffbd6781a/192/3.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 29:
                                Message message29 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/345/7c2/3457c236-4b9c-3e7c-aa95-939ffbd6781a/192/23.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 30:
                                Message message30 = await client.SendStickerAsync(
                                chatId: msg.Chat.Id,
                                sticker: "https://tlgrm.ru/_/stickers/345/7c2/3457c236-4b9c-3e7c-aa95-939ffbd6781a/192/39.webp",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                        }
                        break;
                    case "Picture":
                        switch (rnd.Next(1, 16))
                        {
                            case 1:
                                Message messagee1 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/ittalentestonia/175",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 2:
                                Message messagee2 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/ittalentestonia/174",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 3:
                                Message messagee3 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/ittalentestonia/172",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 4:
                                Message messagee4 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/ittalentestonia/52",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 5:
                                Message messagee5 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/ittalentestonia/9",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 6:
                                Message messagee6 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/739",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 7:
                                Message messagee7 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/740",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 8:
                                Message messagee8 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/713",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 9:
                                Message messagee9 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/714",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 10:
                                Message messagee10 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/355?single",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 11:
                                Message messagee11 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/430",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 12:
                                Message messagee12 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/431",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 13:
                                Message messagee13 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/390",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;

                            case 14:
                                Message messagee14 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/159",
                                replyToMessageId: msg.MessageId,                                                                                                                                                                                                                                                    
                                replyMarkup: GetButtons());
                                break;              
                            case 15:
                                Message messagee29 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/353",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 16:
                                Message messagee30 = await client.SendPhotoAsync(
                                chatId: msg.Chat.Id,
                                photo: "https://t.me/chayka_iz_tallinna/246",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;


                        }

                        break;
                    case "Video":
                        switch (rnd.Next(1, 10))
                        {
                            case 1:
                                Message messagee1 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/smechnoe_video/34",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 2:
                                Message messagee2 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/yumor4/1094",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 3:
                                Message messagee3 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/yumor4/1081",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 4:
                                Message messagee4 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/yumor4/1066",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 5:
                                Message messagee5 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/yumor4/1041",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 6:
                                Message messagee6 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/smehobaza/1651",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 7:
                                Message messagee7 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/Fun_vidos/4469",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 8:
                                Message messagee8 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/Fun_vidos/4408",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 9:
                                Message messagee9 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/yumor4/1006",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 10:
                                Message messagee10 = await client.SendVideoAsync(
                                chatId: msg.Chat.Id,
                                video: "https://t.me/yumor4/997",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;

                        }

                        break;
                    case "Music":
                        switch (rnd.Next(1, 10))
                        {
                            case 1:
                                Message messagee1 = await client.SendAudioAsync(
                                chatId: msg.Chat.Id,
                               audio: "https://t.me/muzyka_musicx/10905",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 2:
                                Message messagee2 = await client.SendAudioAsync(
                                 chatId: msg.Chat.Id,
                                audio: "https://t.me/muzyka_musicx/10893",
                                 replyToMessageId: msg.MessageId,
                                 replyMarkup: GetButtons());
                                break;
                            case 3:
                                Message messagee3 = await client.SendAudioAsync(
                                 chatId: msg.Chat.Id,
                                audio: "https://t.me/muzyka_musicx/10892",
                                 replyToMessageId: msg.MessageId,
                                 replyMarkup: GetButtons());
                                break;
                            case 4:
                                Message messagee4 = await client.SendAudioAsync(
                                 chatId: msg.Chat.Id,
                                audio: "https://t.me/muzyka_musicx/10891",
                                 replyToMessageId: msg.MessageId,
                                 replyMarkup: GetButtons());
                                break;
                            case 5:
                                Message messagee5 = await client.SendAudioAsync(
                                 chatId: msg.Chat.Id,
                                audio: "https://t.me/muzyka_musicx/10873",
                                 replyToMessageId: msg.MessageId,
                                 replyMarkup: GetButtons());
                                break;
                            case 6:
                                Message messagee6 = await client.SendAudioAsync(
                                chatId: msg.Chat.Id,
                               audio: "https://t.me/muzyka_musicx/10861",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 7:
                                Message messagee7 = await client.SendAudioAsync(
                                chatId: msg.Chat.Id,
                               audio: "https://t.me/music_muzyka_vk/14155",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 8:
                                Message messagee8 = await client.SendAudioAsync(
                                chatId: msg.Chat.Id,
                               audio: "https://t.me/music_muzyka_vk/14026",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 9:
                                Message messagee9 = await client.SendAudioAsync(
                                  chatId: msg.Chat.Id,
                                 audio: "https://t.me/music_muzyka_vk/13986",
                                  replyToMessageId: msg.MessageId,
                                  replyMarkup: GetButtons());
                                break;
                            case 10:
                                Message messagee10 = await client.SendAudioAsync(
                                chatId: msg.Chat.Id,
                               audio: "https://t.me/music_muzyka_vk/13982",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;

                        }

                        break;
                    case "Messages":
                        switch (rnd.Next(1, 35))
                        {
                            case 1:
                                Message messagee1 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Самая крупная жемчужина в мире достигает 6 килограммов в весе.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 2:
                                Message messagee2 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Законодательство США допускало отправку детей по почте до 1913 года.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 3:
                                Message messagee3 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "В языке древних греков не существовало слова, которое обозначало религию.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 4:
                                Message messagee4 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "В современной истории есть промежуток времени, когда на счетах компании «Apple», было больше средств, чем у американского правительства.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 5:
                                Message messagee5 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Среднее облако весит порядка 500 тонн, столько же весят 80 слонов.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 6:
                                Message messagee6 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "В Ирландии никогда не было кротов.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 7:
                                Message messagee7 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Флот США содержит больше авианосцев, чем все флоты мира вместе взятые.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 8:
                                Message messagee8 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Скорость распространения лавы после извержения, близка к скорости бега гончей.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 9:
                                Message messagee9 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Изначально, отвертка была изобретена для выковыривания гвоздей, шуруп был изобретен на 100 лет позже.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 10:
                                Message messagee10 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Библия – книга, которую чаще всего воруют в американских магазинах.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 11:
                                Message messagee11 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Примерно 1/3 всей соли, производимой в США, расходуется на очистку дорог ото льда.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 12:
                                Message messagee12 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Существует пробирка, диаметр которой, в 10000 раз меньше диаметра человеческого волоса.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 13:
                                Message messagee13 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Саудовская Аравия не содержит рек.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 14:
                                Message messagee14 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "В Антарктиде существует единственная река – Оникс, она течет всего 60 дней в году.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 15:
                                Message messagee15 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "У медуз нет мозгов и кровеносных сосудов.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 16:
                                Message messagee16 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Ежедневно 60 человек становятся миллионерами.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 17:
                                Message messagee17 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "До 17 века термометры заполняли коньяком.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 18:
                                Message messagee18 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Кошки спят больше половины своей жизни.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 19:
                                Message messagee19 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Лимон содержит больше сахара, чем клубника.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 20:
                                Message messagee20 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Самый долгий полёт курицы продолжался 13 секунд.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 21:
                                Message messagee21 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Ладожское озеро является самым большим в Европе.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 22:
                                Message messagee22 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "За год на Землю падает до 500 кг марсианского метеорита.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 23:
                                Message messagee23 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Земля делает полный оборот вокруг своей оси за 23 часа 56 минут и 4 секунды.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 24:
                                Message messagee24 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "На Юпитере регулярно идут алмазные дожди.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 25:
                                Message messagee25 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Во вселенной больше звёзд, чем песчинок на всех пляжах Земли.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 26:
                                Message messagee26 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "В мире всего 7% левшей",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 27:
                                Message messagee27 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Правое лёгкое человека вмещает больше воздуха, чем левое.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 28:
                                Message messagee28 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Самая трудно излечимая фобия – боязнь страха.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 29:
                                Message messagee29 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Алмазы могут гореть.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 30:
                                Message messagee30 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Корова может подняться по лестнице, но не может спуститься.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 31:
                                Message messagee31 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Утки способны нырять на глубину до 6 метров.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 32:
                                Message messagee32 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Китайский язык является самым популярным в мире.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 33:
                                Message messagee33 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Китайский язык является самым популярным в мире.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 34:
                                Message messagee34 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Самое высокое здание в Европе находится в Польше(Варшава) :Башня Варсо .",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;
                            case 35:
                                Message messagee35 = await client.SendTextMessageAsync(
                                chatId: msg.Chat.Id,
                                text: "Страусы развивают скорость до 70 км в час.",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());
                                break;

                        }

                        break;
                    case "Contact":
                        switch (rnd.Next(1,3))
                        {
                            case 1:

                                Message message1 = await client.SendContactAsync(
                                chatId: msg.Chat.Id,
                                phoneNumber: "+37257852400",
                                firstName: "Nastya",
                                lastName: "Bot",
                                 vCard: "BEGIN:VCARD\n" +
                                "VERSION:3.0\n" +
                                "N:Solo;Han\n" +
                                "TEL;TYPE=voice,work,pref:37257852403\n" +
                                "EMAIL:nastya@bot.com\n" +
                                "EMAIL:hansolo@mfalcon.com\n" +
                                "END:VCARD",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());

                        break;
                            case 2:

                                Message message2 = await client.SendContactAsync(
                                chatId: msg.Chat.Id,
                                phoneNumber: "+37257852400",
                                firstName: "Anastasia",
                                lastName: "Bot",
                                 vCard: "BEGIN:VCARD\n" +
                                "VERSION:3.0\n" +
                                "N:Solo;Han\n" +
                                "TEL;TYPE=voice,work,pref:37257852400\n" +
                                "EMAIL:anastasia@bot.com\n" +
                                "END:VCARD",
                                replyToMessageId: msg.MessageId,
                                replyMarkup: GetButtons());

                                break;

                        }
                        break;

                    default:
                        await client.SendTextMessageAsync(msg.Chat.Id, "Выберите команду: ", replyMarkup: GetButtons());
                        break;
                }

            }
        }

        private static IReplyMarkup GetButtons()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton { Text = "Sticker" }, new KeyboardButton { Text = "Picture"} },
                    new List<KeyboardButton>{ new KeyboardButton { Text = "Music" }, new KeyboardButton { Text = "Video" } },
                    new List<KeyboardButton>{ new KeyboardButton { Text = "Messages" }, new KeyboardButton { Text = "Contact" } }
                }
            };
        }
    }
}