# Batch-Recompressor
An application for batch recompressing videos with an approximate input size and output size E.g 6:1.

# To Do List:
- [X] Default video codec should be AV1, but should also support H.265 (HEVC)
- [X] Better AV1 Codec (svt-av1)
- [X] File Container selection
- [ ] Two modes :
  - Average Bitrate Mode (computable, user can select the compression ratio, a.k.a Shrink Factor)
  - Quality Bitrate Mode (CRF) 
    - lookup table / formula that will select the CRF number according to the input bitrate
    - the appropriate CRF number depends on the input file size, framerate and resolution
- [X] Audio Codec (Passthrough / Opus - Bitrate selected by user, 64kbit/s as default)
- [X] Allow for [multi-pass](https://gitlab.com/AOMediaCodec/SVT-AV1/-/blob/master/Docs/CommonQuestions.md#multi-pass-encoding)
- [ ] Control of the quality setting, `-p 4` (0 to 11) 
- [X] File list (drag & drop)
- [X] Separate window for process queue (Job Window)
- [X] Pre-process input file (combobox - ffmpeg args)
- [X] Post-process ffmpeg options (after main process)
- [X] Automatic file overriding if output file has the incorrect ratio
- [ ] Compatibility Check (Certain Container does not work with specific codecs)

## License 
This project is licensed under the [MIT License](LICENSE).